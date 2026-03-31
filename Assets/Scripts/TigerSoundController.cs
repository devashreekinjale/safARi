using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class TigerSoundController : MonoBehaviour
{
    public AudioSource TigerSound;
    public AudioSource TigerNarration;

    public void OnTargetLost()
    {
        TigerSound.Stop(); 
        TigerNarration.Stop();
    }
}
