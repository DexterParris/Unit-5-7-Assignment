using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{
    public GameObject uiParent;

    public AudioSource swordSlashSound;

    private void Start()
    {
        swordSlashSound = GameObject.Find("SwordSlash").GetComponent<AudioSource>();   
    }

    public void GameplayStart()
    {
        SceneManager.LoadScene("GameplayScene");

    }

    public void GameplayStop()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Cancel()
    {
        swordSlashSound.Play();
        uiParent.SetActive(false);
    }

}
