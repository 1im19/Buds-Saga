using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class WaveBattle : MonoBehaviour
{
    public static int wave = 1;

    private GameObject playerattackimage;
    private GameObject opponentattackimage;

    private AudioClip playerattackaudio;
    private AudioClip opponentattackaudio;

    private AudioSource attackaudio;

    public GameObject enemystatsdisplaypanel;
    public GameObject battlepanel;
    public GameObject statsupgradepanel;
    public GameObject gameoverpanel;
    public GameObject playerhud;
    public GameObject opponenthud;

    public Text wavecountertext;
    public Text playercharacternametext;
    public Text opponentcharacternametext;
    public Text opponentdamagetext;
    public Text playerdamagetext;

    public Text opponentstatstext;
    //public Text battleText;
    public Text playerhealthtext;
    public Text opponenthealthtext;

    private bool playerturn;

    private int opponentdamage;
    private int playerdamage;


    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        attackaudio = GetComponent<AudioSource>();
        playerturn = true;

        playerattackimage = PlayerBattle.playerattackimage;
        opponentattackimage = OpponentBattle.opponentattackimage;

        playerattackaudio = PlayerBattle.playerattackaudio;
        opponentattackaudio  = OpponentBattle.opponentattackaudio;

        playercharacternametext.text = PlayerBattle.charactername;
        opponentcharacternametext.text = OpponentBattle.charactername;

        opponentdamagetext.gameObject.SetActive(false);
        playerdamagetext.gameObject.SetActive(false);

        playerattackimage.SetActive(false);
        opponentattackimage.SetActive(false);

        enemystatsdisplaypanel.SetActive(true);
        battlepanel.SetActive(false);
        statsupgradepanel.SetActive(false);
        gameoverpanel.SetActive(false);
        playerhud.SetActive(false);
        opponenthud.SetActive(false);

        wavecountertext.text = "Your wave " + wave.ToString() + " opponent is: ";

        opponentstatstext.text =
            "Opponent Stats: \n\n" +
            "Health: " + OpponentBattle.health + "\n" +
            "Strength: " + OpponentBattle.strength + "\n" +
            "Defense: " + OpponentBattle.defense;

        playerhealthtext.text = "Health: " + PlayerBattle.health.ToString();
        opponenthealthtext.text = "Health: " + OpponentBattle.health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void StartBattle()
    {
        battlepanel.SetActive(true);
        StartCoroutine(BattleSequence());
    }

    IEnumerator BattleSequence()
    {
        if (playerturn && PlayerBattle.health > 0)
        {
            StartCoroutine(PlayerAttack());
            playerturn = false;
            yield return new WaitForSeconds(2f);
            StartCoroutine(BattleSequence());
        }
        else if(playerturn && PlayerBattle.health <= 0)
        {
            BattleLost();
        }

        if (!playerturn && OpponentBattle.health > 0)
        {
            StartCoroutine(OpponentAttack());
            playerturn = true;
            yield return new WaitForSeconds(2f);
            StartCoroutine(BattleSequence());
        }
        else if(!playerturn && OpponentBattle.health <= 0)
        {
            BattleWin();
        }
    }

    IEnumerator PlayerAttack()
    {
        playerattackimage.SetActive(true);
        attackaudio.PlayOneShot(playerattackaudio, 0.5f);
        yield return new WaitForSeconds(2f);
        opponentdamage = Random.Range(PlayerBattle.strength * 3 / 4, PlayerBattle.strength * 5 / 4) 
            - Random.Range(OpponentBattle.defense/2, OpponentBattle.defense);
        if (opponentdamage <= 0)
        {
            opponentdamage = Random.Range(1, 5);
        }
        OpponentBattle.health -= opponentdamage;
        if (OpponentBattle.health <= 0)
        {
            OpponentBattle.health = 0;
        }
        opponenthealthtext.text = "Health: " + OpponentBattle.health.ToString();
        opponentdamagetext.gameObject.SetActive(true);
        opponentdamagetext.text = "- " + opponentdamage.ToString();
        playerattackimage.SetActive(false);
        yield return new WaitForSeconds(2f);
        opponentdamagetext.gameObject.SetActive(false);
    }

    IEnumerator OpponentAttack()
    {
        opponentattackimage.SetActive(true);
        attackaudio.PlayOneShot(opponentattackaudio, 0.5f);
        yield return new WaitForSeconds(2f);
        playerdamage = Random.Range(OpponentBattle.strength * 3 / 4, OpponentBattle.strength * 5 / 4) 
            - Random.Range(PlayerBattle.defense * 3 / 4, PlayerBattle.defense * 5 / 4);
        if(playerdamage <= 0)
        {
            playerdamage = Random.Range(1, 5);
        }
        PlayerBattle.health -= playerdamage;
        if (PlayerBattle.health <= 0)
        {
            PlayerBattle.health = 0;
        }
        playerhealthtext.text = "Health: " + PlayerBattle.health.ToString();
        playerdamagetext.gameObject.SetActive(true);
        playerdamagetext.text = "- " + playerdamage.ToString();
        opponentattackimage.SetActive(false);
        yield return new WaitForSeconds(2f);
        playerdamagetext.gameObject.SetActive(false);
    }

    private void BattleWin()
    {
        battlepanel.SetActive(false);
        playerhud.SetActive(false);
        opponenthud.SetActive(false);
        statsupgradepanel.SetActive(true);
        audioManager.stopMusic();
        audioManager.PlaySFX(audioManager.Win);
    }

    private void BattleLost()
    {
        battlepanel.SetActive(false);
        playerhud.SetActive(false);
        opponenthud.SetActive(false);
        gameoverpanel.SetActive(true);
        audioManager.EMusicPlay();
    }

    private void DebugLogging()
    {
        Debug.Log("Player's Health: " + PlayerBattle.health);
        Debug.Log("Player's Strength: " + PlayerBattle.strength);
        Debug.Log("Player's Defense: " + PlayerBattle.defense);

        Debug.Log("Opponent's Health: " + OpponentBattle.health);
        Debug.Log("Opponent's Strength: " + OpponentBattle.strength);
        Debug.Log("Opponent's Defense: " + OpponentBattle.defense);
    }
}
