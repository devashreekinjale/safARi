using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class SharkSoundController : MonoBehaviour
{
    public AudioSource SharkSound;
    public AudioSource SharkNarration;

    public void OnTargetLost()
    {
        SharkSound.Stop(); 
        SharkNarration.Stop();
    }
}
