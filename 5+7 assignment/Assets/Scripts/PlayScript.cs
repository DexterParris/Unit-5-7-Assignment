using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScript : MonoBehaviour
{
    public GameObject gameplay;

    public void gameplayon()
    {
        gameplay.SetActive(true);

    }
    public void gameplayoff()
    {
        gameplay.SetActive(false);
    }
}
