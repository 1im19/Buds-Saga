using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [Header("-------- Audio Source -----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-------- Audio Clip -----------")]
    public AudioClip Mbackground;
    public AudioClip Bbackground;
    public AudioClip Ebackground;
    public AudioClip Yclick;
    public AudioClip Nclick;
    public AudioClip Win;

    public static AudioManager instance;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        
    }

    public void MMusicPlay()
    {
        musicSource.clip = Mbackground;
        musicSource.Play();
    }

    public void BMusicPlay()
    {
        musicSource.clip = Bbackground;
        musicSource.Play();
    }

    public void EMusicPlay()
    {
        musicSource.clip = Ebackground;
        musicSource.Play();
    }

    public void stopMusic()
    {
        musicSource.Stop();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
