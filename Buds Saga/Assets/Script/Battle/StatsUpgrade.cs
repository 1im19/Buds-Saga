using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatsUpgrade : MonoBehaviour
{
    public Text healthupgradetext;
    public Text strengthupgradetext;
    public Text defenseupgradetext;
    // Start is called before the first frame update
    void Start()
    {
        if (CharacterSelect.characterchoice == 1)
        {
            healthupgradetext.text = "HP: 100";
            strengthupgradetext.text = "Strength: 20";
            defenseupgradetext.text = "Defense: 10";
        }
        else if (CharacterSelect.characterchoice == 2)
        {
            healthupgradetext.text = "HP: 200";
            strengthupgradetext.text = "Strength: 10";
            defenseupgradetext.text = "Defense: 5";
        }
        else if (CharacterSelect.characterchoice == 3)
        {
            healthupgradetext.text = "HP: 80";
            strengthupgradetext.text = "Strength: 40";
            defenseupgradetext.text = "Defense: 5";
        }
        else if (CharacterSelect.characterchoice == 4)
        {
            healthupgradetext.text = "HP: 80";
            strengthupgradetext.text = "Strength: 10";
            defenseupgradetext.text = "Defense: 20";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpgradePlayerStats(int choice)
    {
        if (choice == 1)
        {
            if (CharacterSelect.characterchoice == 1)
            {
                PlayerBattle.maxHealth += 100;
                PlayerBattle.health = PlayerBattle.maxHealth;
            }
            else if (CharacterSelect.characterchoice == 2)
            {
                PlayerBattle.maxHealth += 200;
                PlayerBattle.health = PlayerBattle.maxHealth;
            }
            else if (CharacterSelect.characterchoice == 3)
            {
                PlayerBattle.maxHealth += 80;
                PlayerBattle.health = PlayerBattle.maxHealth;
            }
            else if (CharacterSelect.characterchoice == 4)
            {
                PlayerBattle.maxHealth += 80;
                PlayerBattle.health = PlayerBattle.maxHealth;
            }
        }
        else if (choice == 2)
        {
            if (CharacterSelect.characterchoice == 1)
            {
                PlayerBattle.strength += 20;
                PlayerBattle.health = PlayerBattle.maxHealth;
            }
            else if (CharacterSelect.characterchoice == 2)
            {
                PlayerBattle.strength += 10;
                PlayerBattle.health = PlayerBattle.maxHealth;
            }
            else if (CharacterSelect.characterchoice == 3)
            {
                PlayerBattle.strength += 40;
                PlayerBattle.health = PlayerBattle.maxHealth;
            }
            else if (CharacterSelect.characterchoice == 4)
            {
                PlayerBattle.strength += 10;
                PlayerBattle.health = PlayerBattle.maxHealth;
            }
        }
        else if (choice == 3)
        {
            if (CharacterSelect.characterchoice == 1)
            {
                PlayerBattle.defense += 10;
                PlayerBattle.health = PlayerBattle.maxHealth;
            }
            else if (CharacterSelect.characterchoice == 2)
            {
                PlayerBattle.defense += 5;
                PlayerBattle.health = PlayerBattle.maxHealth;
            }
            else if (CharacterSelect.characterchoice == 3)
            {
                PlayerBattle.defense += 5;
                PlayerBattle.health = PlayerBattle.maxHealth;
            }
            else if (CharacterSelect.characterchoice == 4)
            {
                PlayerBattle.defense += 20;
                PlayerBattle.health = PlayerBattle.maxHealth;
            }
        }
        UpgradeOpponentStats();
        WaveBattle.wave += 1;
        SceneManager.LoadScene("Battle");
    }

    private void UpgradeOpponentStats()
    {
        TappyOpponent.UpgradeStats();
        OguOpponent.UpgradeStats();
        BiggieOpponent.UpgradeStats();
        BamOpponent.UpgradeStats();
    }
}
