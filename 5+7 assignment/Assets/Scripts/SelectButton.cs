using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButton : MonoBehaviour
{
    public GameObject selectedButton;

    void Start()
    {
        selectedButton.GetComponent<Button>().Select();
    }

}
