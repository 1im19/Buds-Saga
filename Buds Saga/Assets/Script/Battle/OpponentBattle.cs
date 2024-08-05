using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpponentBattle : MonoBehaviour
{
    //Character Panel
    public GameObject tappyopponent;
    public GameObject oguopponent;
    public GameObject biggieopponent;
    public GameObject bamopponent;

    public GameObject tappyopponentpanel;
    public GameObject oguopponentpanel;
    public GameObject biggieopponentpanel;
    public GameObject bamopponentpanel;

    //Character Attack Images
    public GameObject tappyopponentattackimage;
    public GameObject oguopponentattackimage;
    public GameObject biggieopponentattackimage;
    public GameObject bamopponentattackimage;

    //Opponent Attack Audio
    public AudioClip tappyopponentattackaudio;
    public AudioClip oguopponentattackaudio;
    public AudioClip biggieopponentattackaudio;
    public AudioClip bamopponentattackaudio;

    public static GameObject opponentattackimage;
    public static AudioClip opponentattackaudio;

    public static string charactername;
    public static int health;
    public static int maxHealth;
    public static int strength;
    public static int defense;

    private int opponentchoice; //for rng enemy

    // Start is called before the first frame update
    void Start()
    {
        tappyopponent.SetActive(false);
        oguopponent.SetActive(false);
        biggieopponent.SetActive(false);
        bamopponent.SetActive(false);

        tappyopponentpanel.SetActive(false);
        oguopponentpanel.SetActive(false);
        biggieopponentpanel.SetActive(false);
        bamopponentpanel.SetActive(false);

        opponentchoice = Random.Range(0, 300);
        //Debug.Log("Opponent Choice RNG: " + opponentchoice);
        OpponentChoice();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OpponentChoice()
    {
        if (CharacterSelect.characterchoice == 1)
        {
            if (opponentchoice >= 0 && opponentchoice <= 100)
            {
                SetOguAsOpponent();
            }
            else if (opponentchoice > 100 && opponentchoice <= 200)
            {
                SetBiggieAsOpponent();
            }
            else if (opponentchoice > 200 && opponentchoice <= 300)
            {
                SetBamAsOpponent();
            }
        }
        else if (CharacterSelect.characterchoice == 2)
        {
            if (opponentchoice >= 0 && opponentchoice <= 100)
            {
                SetTappyAsOpponent();
            }
            else if (opponentchoice > 100 && opponentchoice <= 200)
            {
                SetBiggieAsOpponent();
            }
            else if (opponentchoice > 200 && opponentchoice <= 300)
            {
                SetBamAsOpponent();
            }
        }
        else if (CharacterSelect.characterchoice == 3)
        {
            if (opponentchoice >= 0 && opponentchoice <= 100)
            {
                SetTappyAsOpponent();
            }
            else if (opponentchoice > 100 && opponentchoice <= 200)
            {
                SetOguAsOpponent();
            }
            else if (opponentchoice > 200 && opponentchoice <= 300)
            {
                SetBamAsOpponent();
            }
        }
        else if (CharacterSelect.characterchoice == 4)
        {
            if (opponentchoice >= 0 && opponentchoice <= 100)
            {
                SetTappyAsOpponent();
            }
            else if (opponentchoice > 100 && opponentchoice <= 200)
            {
                SetOguAsOpponent();
            }
            else if (opponentchoice > 200 && opponentchoice <= 300)
            {
                SetBiggieAsOpponent();
            }
        }
    }

    private void SetTappyAsOpponent()
    {
        tappyopponent.SetActive(true);
        oguopponent.SetActive(false);
        biggieopponent.SetActive(false);
        bamopponent.SetActive(false);

        tappyopponentpanel.SetActive(true);
        oguopponentpanel.SetActive(false);
        biggieopponentpanel.SetActive(false);
        bamopponentpanel.SetActive(false);

        opponentattackimage = tappyopponentattackimage;
        opponentattackaudio = tappyopponentattackaudio;

        charactername = TappyOpponent.charactername;
        maxHealth = TappyOpponent.maxhealth;
        health = TappyOpponent.health;
        strength = TappyOpponent.strength;
        defense = TappyOpponent.defense;
    }

    private void SetOguAsOpponent()
    {
        tappyopponent.SetActive(false);
        oguopponent.SetActive(true);
        biggieopponent.SetActive(false);
        bamopponent.SetActive(false);

        tappyopponentpanel.SetActive(false);
        oguopponentpanel.SetActive(true);
        biggieopponentpanel.SetActive(false);
        bamopponentpanel.SetActive(false);

        opponentattackimage = oguopponentattackimage;
        opponentattackaudio = oguopponentattackaudio;

        charactername = OguOpponent.charactername;
        maxHealth = OguOpponent.maxhealth;
        health = OguOpponent.health;
        strength = OguOpponent.strength;
        defense = OguOpponent.defense;
    }

    private void SetBiggieAsOpponent()
    {
        tappyopponent.SetActive(false);
        oguopponent.SetActive(false);
        biggieopponent.SetActive(true);
        bamopponent.SetActive(false);

        tappyopponentpanel.SetActive(false);
        oguopponentpanel.SetActive(false);
        biggieopponentpanel.SetActive(true);
        bamopponentpanel.SetActive(false);

        opponentattackimage = biggieopponentattackimage;
        opponentattackaudio = biggieopponentattackaudio;

        charactername = BiggieOpponent.charactername;
        maxHealth = BiggieOpponent.maxhealth;
        health = BiggieOpponent.health;
        strength = BiggieOpponent.strength;
        defense = BiggieOpponent.defense;
    }

    private void SetBamAsOpponent()
    {
        tappyopponent.SetActive(false);
        oguopponent.SetActive(false);
        biggieopponent.SetActive(false);
        bamopponent.SetActive(true);

        tappyopponentpanel.SetActive(false);
        oguopponentpanel.SetActive(false);
        biggieopponentpanel.SetActive(false);
        bamopponentpanel.SetActive(true);

        opponentattackimage = bamopponentattackimage;
        opponentattackaudio = bamopponentattackaudio;

        charactername = BamOpponent.charactername;
        maxHealth = BamOpponent.maxhealth;
        health = BamOpponent.health;
        strength = BamOpponent.strength;
        defense = BamOpponent.defense;
    }
}
