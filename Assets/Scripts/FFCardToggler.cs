using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FFCardToggler : MonoBehaviour
{
    bool isOn = false;
    [SerializeField] GameObject FFCard;

    public void toggleCard()
    {
        if(isOn)
        {
            FFCard.SetActive(false);
            isOn = false;
        }
        else
        {
            FFCard.SetActive(true);
            isOn = true;
        }
    }

}
