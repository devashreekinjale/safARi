using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardToggler : MonoBehaviour
{
    bool isOn = false;
    [SerializeField] GameObject Card;

    public void toggleCard()
    {
        if(isOn)
        {
            Card.SetActive(false);
            isOn = false;
        }
        else
        {
            Card.SetActive(true);
            isOn = true;
        }
    }
}
