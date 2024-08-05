using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TappyOpponent : MonoBehaviour
{
    public static string charactername = "Tappy";
    public static int health = 100;
    public static int maxhealth = 100;
    public static int strength = 20;
    public static int defense = 10;

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
        maxhealth += 20;
        health = maxhealth;
        strength += 10;
        defense += 5;
    }
}
