using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void Start()
    {
        audioManager.MMusicPlay();
    }

    public void onPlayButton()
    {
        SceneManager.LoadScene("CharacterSelect");
        audioManager.PlaySFX(audioManager.Yclick);
    }

    public void onYBUtton()
    {
        audioManager.PlaySFX(audioManager.Yclick);
    }

    public void onNBUtton()
    {
        audioManager.PlaySFX(audioManager.Nclick);
    }

}
