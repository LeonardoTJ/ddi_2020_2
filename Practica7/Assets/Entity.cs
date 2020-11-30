using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Entity : MonoBehaviour
{
    private int health;
    public Sprite weaponIcon;
    public string weaponName;
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetHealth()
    {
        return health;
    }

    public bool ReceiveAttack()
    {
        health -= 1;
        return (health < 1);
    }
}
