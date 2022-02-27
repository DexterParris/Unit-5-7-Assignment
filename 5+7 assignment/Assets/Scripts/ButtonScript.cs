using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject selectedButton;
    public GameObject target;
    public GameObject uiParent;
    public AudioSource swordSlashSound;

    private void Start()
    {
        swordSlashSound = GameObject.Find("SwordSlash").GetComponent<AudioSource>();   
    }
    public void ChangeMenu()
    {
        swordSlashSound.Play();
        target.SetActive(true);
        uiParent.SetActive(false);
        selectedButton.GetComponent<Button>().Select();
    }


}
