using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DifficultyScript : MonoBehaviour
{
    public TMP_Dropdown selector;

    // Start is called before the first frame update
    public void ChangeValue()
    {
        selector = GetComponent<TMP_Dropdown>();

        PlayerPrefs.SetInt("difficultyPref", selector.value);
    }

    // Update is called once per frame
    void Start()
    {
        selector = selector.GetComponent<TMP_Dropdown>();
        selector.value = PlayerPrefs.GetInt("difficultyPref", 0);
    }
}
