using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeScript : MonoBehaviour
{
    public float volumeValue;
    public float musicVolumeValue;
    public float sfxVolumeValue;

    public TextMeshProUGUI volumeText;
    public TextMeshProUGUI musicText;
    public TextMeshProUGUI sfxText;

    public Slider mSlider;
    public Slider vmSlider;
    public Slider sfxSlider;

    // Start is called before the first frame update
    void Start()
    {
        volumeValue = PlayerPrefs.GetFloat("uiVolume");
        musicVolumeValue = PlayerPrefs.GetFloat("musicVolume");
        sfxVolumeValue = PlayerPrefs.GetFloat("sfxVolume");


        mSlider.value = volumeValue;
        vmSlider.value = musicVolumeValue;
        sfxSlider.value = sfxVolumeValue;
    }

    public void ChangeMasterVolume()
    {
        volumeValue = mSlider.value;
        PlayerPrefs.SetFloat("uiVolume", volumeValue);
        volumeText.text = (volumeValue*100).ToString("F0")+"%";
    }

    public void ChangeMusicVolume()
    {
        musicVolumeValue = vmSlider.value;
        PlayerPrefs.SetFloat("musicVolume", musicVolumeValue);
        musicText.text = (musicVolumeValue *100).ToString("F0") + "%";
    }

    public void ChangeSFXVolume()
    {
        sfxVolumeValue = sfxSlider.value;
        PlayerPrefs.SetFloat("sfxVolume", sfxVolumeValue);
        sfxText.text = (sfxVolumeValue *100).ToString("F0") + "%";
    }

}
