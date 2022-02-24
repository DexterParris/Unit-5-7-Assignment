using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeScript : MonoBehaviour
{
    public float volumeValue;
    public TextMeshProUGUI volumeText;
    string displaytext = "a"; 

    public Slider vslider;

    // Start is called before the first frame update
    void Start()
    {
        volumeValue = PlayerPrefs.GetFloat("uiVolume");
        vslider.value = volumeValue;
    }

    public void ChangeVolume()
    {
        volumeValue = vslider.value;
        PlayerPrefs.SetFloat("uiVolume", volumeValue);
        volumeText.text = volumeValue.ToString("F2");
    }

}
