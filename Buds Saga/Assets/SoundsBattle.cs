using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsBattle : MonoBehaviour
{
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

    public void onBattleMusic()
    {
        audioManager.BMusicPlay();
    }

    public void onStopMusic()
    {
        audioManager.stopMusic();
    }

}
