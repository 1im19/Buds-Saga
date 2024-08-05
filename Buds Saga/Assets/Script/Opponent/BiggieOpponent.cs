using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiggieOpponent : MonoBehaviour
{
    public static string charactername = "Biggie";
    public static int health = 80;
    public static int maxhealth = 80;
    public static int strength = 40;
    public static int defense = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void UpgradeStats()
    {
        maxhealth += 10;
        health = maxhealth;
        strength += 40;
        defense += 2;
    }
}