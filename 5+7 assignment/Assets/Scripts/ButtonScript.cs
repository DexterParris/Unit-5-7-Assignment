using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject selectedButton;
    public GameObject target;
    public GameObject uiParent;

    private void Start()
    {
        if(selectedButton != null)
        {
            selectedButton.SetActive(true);
        }
        else if (selectedButton == null)
        {
            selectedButton.SetActive(false);
        }
    }
    public void ChangeMenu()
    {
        target.SetActive(true);
        uiParent.SetActive(false);
        selectedButton.GetComponent<Button>().Select();
    }
}
