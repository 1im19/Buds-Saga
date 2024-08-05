using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamOpponent : MonoBehaviour
{
    public static string charactername = "Bam";
    public static int health = 80;
    public static int maxhealth = 80;
    public static int strength = 10;
    public static int defense = 20;

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
        strength += 5;
        defense += 10;
    }
}
