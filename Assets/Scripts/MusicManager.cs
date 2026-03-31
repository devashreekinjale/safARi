using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public Slider musicSlider;     // Assign in Inspector
    public AudioSource musicSource; // Your background music

    void Start()
    {
        if (PlayerPrefs.HasKey("musicState"))
        {
            LoadMusicState();
        }
        else
        {
            PlayerPrefs.SetFloat("musicState", 1); // Default ON
            LoadMusicState();
        }
    }

    public void ToggleMusic()
    {
        if (musicSlider.value == 0)
        {
            musicSource.Pause(); // OFF
        }
        else
        {
            musicSource.Play(); // ON
        }

        SaveMusicState();
    }

    void SaveMusicState()
    {
        PlayerPrefs.SetFloat("musicState", musicSlider.value);
    }

    void LoadMusicState()
    {
        float state = PlayerPrefs.GetFloat("musicState");
        musicSlider.value = state;

        if (state == 0)
        {
            musicSource.Pause();
        }
        else
        {
            musicSource.Play();
        }
    }
}