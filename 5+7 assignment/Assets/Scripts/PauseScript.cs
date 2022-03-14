using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public GameObject menu;
    public GameObject selectedButton;
    public bool isactive= false;
    // Update is called once per frame
    void Update()
    {
        if(isactive == false && Input.GetKeyDown(KeyCode.Escape))
        {
            isactive = true;
            menu.SetActive(true);
            selectedButton.GetComponent<Button>().Select();
        }
        else if(isactive == true && Input.GetKeyDown(KeyCode.Escape))
        {
            menu.SetActive(false);
            isactive = false;
        }
    }
}
