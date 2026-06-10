using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider sfxSlider;
    private void Start()
    {
        float savedMusic = PlayerPrefs.GetFloat("MusicVolume", 0f);
        float savedSFX = PlayerPrefs.GetFloat("SFXVolume", 0f);

        if (musicSlider != null) musicSlider.value = savedMusic;
        if (sfxSlider != null) sfxSlider.value = savedSFX;

        SetMusicVolume(savedMusic);
        SetSFXVolume(savedSFX);
    }

    public void SetMusicVolume(float value)
    {
        if (value <= -40f) audioMixer.SetFloat("MusicVol", -80f);
        else audioMixer.SetFloat("MusicVol", value);

        PlayerPrefs.SetFloat("MusicVolume", value);
        PlayerPrefs.Save();
    }

    public void SetSFXVolume(float value)
    {
        if (value <= -40f) audioMixer.SetFloat("SFXVol", -80f);
        else audioMixer.SetFloat("SFXVol", value);

        PlayerPrefs.SetFloat("SFXVolume", value);
        PlayerPrefs.Save();
    }
}
