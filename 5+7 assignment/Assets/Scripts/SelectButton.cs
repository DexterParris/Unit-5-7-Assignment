using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButton : MonoBehaviour
{
    public GameObject selectedButton;
    // Start is called before the first frame update
    void Start()
    {
        selectedButton.GetComponent<Button>().Select();
    }

}