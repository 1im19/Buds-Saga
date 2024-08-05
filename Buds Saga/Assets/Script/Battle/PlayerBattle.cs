using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBattle : MonoBehaviour
{
    //Character Panel
    public GameObject tappyplayer;
    public GameObject oguplayer;
    public GameObject biggieplayer;
    public GameObject bamplayer;

    //Character Attack Images
    public GameObject tappyplayerattackimage;
    public GameObject oguplayerattackimage;
    public GameObject biggieplayerattackimage;
    public GameObject bamplayerattackimage;

    //Character Attack Audio
    public AudioClip tappyplayerattackaudio;
    public AudioClip oguplayerattackaudio;
    public AudioClip biggieplayerattackaudio;
    public AudioClip bamplayerttackaudio;

    public static GameObject playerattackimage;
    public static AudioClip playerattackaudio;

    public static string charactername;
    public static int health;
    public static int maxHealth;
    public static int strength;
    public static int defense;

    // Start is called before the first frame update
    void Start()
    {
        CharacterChoice();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CharacterChoice()
    {
        if (CharacterSelect.characterchoice == 1)
        {
            tappyplayer.SetActive(true);
            oguplayer.SetActive(false);
            biggieplayer.SetActive(false);
            bamplayer.SetActive(false);

            playerattackimage = tappyplayerattackimage;
            playerattackaudio = tappyplayerattackaudio;
        }
        else if (CharacterSelect.characterchoice == 2)
        {
            tappyplayer.SetActive(false);
            oguplayer.SetActive(true);
            biggieplayer.SetActive(false);
            bamplayer.SetActive(false);

            playerattackimage = oguplayerattackimage;
            playerattackaudio = biggieplayerattackaudio;
        }
        else if (CharacterSelect.characterchoice == 3)
        {
            tappyplayer.SetActive(false);
            oguplayer.SetActive(false);
            biggieplayer.SetActive(true);
            bamplayer.SetActive(false);

            playerattackimage = biggieplayerattackimage;
            playerattackaudio = biggieplayerattackaudio;
        }
        else if (CharacterSelect.characterchoice == 4)
        {
            tappyplayer.SetActive(false);
            oguplayer.SetActive(false);
            biggieplayer.SetActive(false);
            bamplayer.SetActive(true);

            playerattackimage = bamplayerattackimage;
            playerattackaudio = bamplayerttackaudio;
        }
    }
}
