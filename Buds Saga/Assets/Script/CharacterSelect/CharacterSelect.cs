using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class CharacterSelect : MonoBehaviour
{
    public static int characterchoice; //for opponentchoice

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void onYBUtton()
    {
        audioManager.PlaySFX(audioManager.Yclick);
    }

    public void onNBUtton()
    {
        audioManager.PlaySFX(audioManager.Nclick);
    }

    public void CharacterSelected(int choice)
    {
        
        switch (choice)
        {

            case 1:
                characterchoice = 1;
                PlayerBattle.charactername = TappyPlayer.charactername;
                PlayerBattle.health = TappyPlayer.health;
                PlayerBattle.maxHealth = TappyPlayer.maxhealth;
                PlayerBattle.strength = TappyPlayer.strength;
                PlayerBattle.defense = TappyPlayer.defense;
                break;
            case 2:
                characterchoice = 2;
                PlayerBattle.charactername = OguPlayer.charactername;
                PlayerBattle.health = OguPlayer.health;
                PlayerBattle.maxHealth = OguPlayer.maxhealth;
                PlayerBattle.strength = OguPlayer.strength;
                PlayerBattle.defense = OguPlayer.defense;
                break;
            case 3:
                characterchoice = 3;
                PlayerBattle.charactername = BiggiePlayer.charactername;
                PlayerBattle.health = BiggiePlayer.health;
                PlayerBattle.maxHealth = BiggiePlayer.maxhealth;
                PlayerBattle.strength = BiggiePlayer.strength;
                PlayerBattle.defense = BiggiePlayer.defense;
                break;
            case 4:
                characterchoice = 4;
                PlayerBattle.charactername = BamPlayer.charactername;
                PlayerBattle.health = BamPlayer.health;
                PlayerBattle.maxHealth = BamPlayer.maxhealth;
                PlayerBattle.strength = BamPlayer.strength;
                PlayerBattle.defense = BamPlayer.defense;
                break;
        }
        SceneManager.LoadScene("Battle");
        audioManager.PlaySFX(audioManager.Yclick);
        
    }

    public void onBackButton()
    {
        SceneManager.LoadScene("MainMenu");
        audioManager.PlaySFX(audioManager.Nclick);
    }
}
