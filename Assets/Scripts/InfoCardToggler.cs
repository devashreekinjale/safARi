using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoCardToggler : MonoBehaviour
{
    bool isOn = false;
    [SerializeField] GameObject InfoCard;

    public void toggleCard()
    {
        if(isOn)
        {
            InfoCard.SetActive(false);
            isOn = false;
        }
        else
        {
            InfoCard.SetActive(true);
            isOn = true;
        }
    }
}
