using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public delegate void OnChange();
    public OnChange onChange;
    public int currentAmmo = 0;
    public const int maxAmmo = 5;
    public static Ammo instance;

    void Start()
    {
        instance = this;
    }
    
    public void LoadBullet()
    {
        currentAmmo += 1;

        if(currentAmmo > maxAmmo)
        {
            currentAmmo = maxAmmo;
        }
    }
}