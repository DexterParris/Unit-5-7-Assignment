using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class VolumeScript : MonoBehaviour
{
    float volumeValue;
    float musicVolumeValue;
    float sfxVolumeValue;

    public AudioMixer mixer;

    

    public TextMeshProUGUI volumeText;
    public TextMeshProUGUI musicText;
    public TextMeshProUGUI sfxText;

    public Slider mSlider;
    public Slider vmSlider;
    public Slider sfxSlider;

    //mute button's stuff
    public static bool _mute = false;
    public TextMeshProUGUI mutetext;
    bool mutestate = false;
    //mute button's stuff


    // Start is called before the first frame update
    void Start()
    {
        volumeValue = PlayerPrefs.GetFloat("uiVolume");
        musicVolumeValue = PlayerPrefs.GetFloat("musicVolume");
        sfxVolumeValue = PlayerPrefs.GetFloat("sfxVolume");


        mSlider.value = volumeValue;
        vmSlider.value = musicVolumeValue;
        sfxSlider.value = sfxVolumeValue;

        if (PlayerPrefs.GetInt("mute") == 0)
        {
            mutestate = false;
            _mute = mutestate;
            mutetext.text = "Mute: Off";
        }
        else
        {
            mutestate = true;
            _mute = mutestate;
            mutetext.text = "Mute: On";
        }
        
    }


    public void ChangeMasterVolume()
    {
        volumeValue = mSlider.value;
        PlayerPrefs.SetFloat("uiVolume", volumeValue);
        volumeText.text = (volumeValue*100).ToString("F0")+"%";
        if(volumeValue == 0f)
        {
            mixer.SetFloat("MasterVol", -80f);
        }
        else if(_mute == true)
        {
            mixer.SetFloat("MasterVol", -80f);
        }
        else
        {
            mixer.SetFloat("MasterVol", Mathf.Log10(volumeValue)*20);
        }
    }

    public void ChangeMusicVolume()
    {
        musicVolumeValue = vmSlider.value;
        PlayerPrefs.SetFloat("musicVolume", musicVolumeValue);
        musicText.text = (musicVolumeValue *100).ToString("F0") + "%";
        if(musicVolumeValue == 0f)
        {
            mixer.SetFloat("MusicVol", -80f);
        }
        else
        {
            mixer.SetFloat("MusicVol", Mathf.Log10(musicVolumeValue)*20);
        }
        
    }

    public void ChangeSFXVolume()
    {
        sfxVolumeValue = sfxSlider.value;
        PlayerPrefs.SetFloat("sfxVolume", sfxVolumeValue);
        sfxText.text = (sfxVolumeValue *100).ToString("F0") + "%";
        if(sfxVolumeValue == 0f)
        {
            mixer.SetFloat("SFXVol", -80f);
        }
        else
        {
            mixer.SetFloat("SFXVol", Mathf.Log10(sfxVolumeValue)*20);
        }
    }

    public void mutecheck()
    {
        if (PlayerPrefs.GetInt("mute") == 0)
        {
            PlayerPrefs.SetInt("mute", 1);
            mutestate = true;
            _mute = mutestate;
            mutetext.text = "Mute: On";

            mixer.SetFloat("MasterVol", -80f);
        }
        else
        {
            PlayerPrefs.SetInt("mute", 0);
            mutestate = false;
            _mute = mutestate;
            mutetext.text = "Mute: Off";

            mixer.SetFloat("MasterVol", Mathf.Log10(volumeValue)*20);
        }
        

    }


    
    

}
