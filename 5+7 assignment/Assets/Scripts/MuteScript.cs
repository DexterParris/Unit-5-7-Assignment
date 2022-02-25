using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MuteScript : MonoBehaviour
{

    public static bool _mute = false;
    public TextMeshProUGUI mutetext;

    bool mutestate = false;
    // Start is called before the first frame update
    void Start()
    {
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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mutecheck()
    {
        if (PlayerPrefs.GetInt("mute") == 0)
        {
            PlayerPrefs.SetInt("mute", 1);
            mutestate = true;
            _mute = mutestate;
            mutetext.text = "Mute: On";
        }
        else
        {
            PlayerPrefs.SetInt("mute", 0);
            mutestate = false;
            _mute = mutestate;
            mutetext.text = "Mute: Off";
        }

    }
}
