using UnityEngine;
using System.Collections;
using System.Net;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using UnityEngine.UI;

using System;

public class DashboardClient : MonoBehaviour {
	public string brokerIpAddress = "localhost";
	public int brokerPort = 1884;
	
	public string alleyLightTopic = "casa/pasillo/movimiento";
	public string backyardLightTopic = "casa/patio/movimiento";
	public string entranceLightTopic = "casa/entrada/movimiento";

	private MqttClient client;
	public Text displayTextEntrance;
	public Text displayTextBackyard;
	public Text displayTextAlley;

	public GameObject alleyLight;
	public GameObject backyardLight;
	public GameObject entranceLight;

	string lastMessage;
	string lightState = "off";

	volatile bool alleyLightState = false;
	volatile bool backyardLightState = false;
	volatile bool entranceLightState = false;
	
	// Use this for initialization
	void Start () {
		// create client instance 
		// client = new MqttClient(IPAddress.Parse(brokerIpAddress), brokerPort, false, null); 
		client = new MqttClient(brokerIpAddress, brokerPort, false, null); 
		
		// register to message received 
		client.MqttMsgPublishReceived += client_MqttMsgPublishReceived; 
		
		string clientId = Guid.NewGuid().ToString(); 
		client.Connect(clientId); 
		
		// subscribe to the topic "/home/temperature" with QoS 2 
		client.Subscribe(new string[] { alleyLightTopic },    new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
		client.Subscribe(new string[] { backyardLightTopic }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
		client.Subscribe(new string[] { entranceLightTopic }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
		
	}

	void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) 
	{ 
		Debug.Log("Received: " + System.Text.Encoding.UTF8.GetString(e.Message)  );
		lastMessage = System.Text.Encoding.UTF8.GetString(e.Message);

		if(e.Topic.Equals(entranceLightTopic))
		{
			entranceLightState = lastMessage.Equals("on");
		}
		else if(e.Topic.Equals(backyardLightTopic))
		{
			backyardLightState = lastMessage.Equals("on");
		}
		else if(e.Topic.Equals(alleyLightTopic))
		{
			alleyLightState = lastMessage.Equals("on");
		}
	}

	void Update()
	{
		displayTextAlley.text    = (alleyLightState)    ? "on" : "off";
		displayTextBackyard.text = (backyardLightState) ? "on" : "off";
		displayTextEntrance.text = (entranceLightState) ? "on" : "off";

		if (alleyLightState != alleyLight.activeSelf)
			alleyLight.SetActive(alleyLightState);
		if (backyardLightState != backyardLight.activeSelf)
			backyardLight.SetActive(backyardLightState);
		if (entranceLightState != entranceLight.activeSelf)
			entranceLight.SetActive(entranceLightState);
	}

	void OnApplicationQuit()
	{
		client.Disconnect();
	}
}
