using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using UnityEngine.UI;
using System;

public class MotionSensor : MonoBehaviour
{
    public string brokerIpAddress = "localhost";
	public int brokerPort = 1883;
	public string motionTopic = "casa/patio/movimiento";
    private MqttClient client;
    string lastMessage;

    // Start is called before the first frame update
    void Start()
    {
        client = new MqttClient(brokerIpAddress, brokerPort, false, null);
        string clientId = Guid.NewGuid().ToString(); 
		client.Connect(clientId); 
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entro");
        if(other.CompareTag("Player"))
        {
            client.Publish(motionTopic,
                           System.Text.Encoding.UTF8.GetBytes("on"), 
                           MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, 
                           true);
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Salio");
        if(other.CompareTag("Player"))
        {
            client.Publish(motionTopic,
                           System.Text.Encoding.UTF8.GetBytes("off"), 
                           MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, 
                           true);
        }
    }

    
    void OnApplicationQuit()
	{
		client.Disconnect();
	}

}
