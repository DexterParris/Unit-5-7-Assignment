using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;

public class MuteScript : MonoBehaviour
{
    float volumeValue;
    float musicVolumeValue;
    float sfxVolumeValue;

    public AudioMixer mixer;
    // Start is called before the first frame update
    void Start()
    {
        volumeValue = PlayerPrefs.GetFloat("uiVolume");
        musicVolumeValue = PlayerPrefs.GetFloat("musicVolume");
        sfxVolumeValue = PlayerPrefs.GetFloat("sfxVolume");

        if (PlayerPrefs.GetInt("mute") == 0)
        {
            mixer.SetFloat("MasterVol", Mathf.Log10(volumeValue)*20);
            mixer.SetFloat("MusicVol", Mathf.Log10(musicVolumeValue)*20);
            mixer.SetFloat("SFXVol", Mathf.Log10(sfxVolumeValue)*20);
        }
        else
        {
            mixer.SetFloat("MasterVol", -80f);
        }
    }

}
