using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class DeerSoundController : MonoBehaviour
{
    public AudioSource DeerSound;
    public AudioSource DeerNarration;

    public void OnTargetLost()
    {
        DeerSound.Stop(); 
        DeerNarration.Stop();
    }
}
