using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class BearSoundController : MonoBehaviour
{
    public AudioSource BearSound;
    public AudioSource BearNarration;

    public void OnTargetLost()
    {
        BearSound.Stop(); 
        BearNarration.Stop();
    }
}
