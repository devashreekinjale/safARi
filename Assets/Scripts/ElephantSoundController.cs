using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class ElephantSoundController : MonoBehaviour
{
    public AudioSource ElephantSound;
    public AudioSource ElephantNarration;

    public void OnTargetLost()
    {
        ElephantSound.Stop(); 
        ElephantNarration.Stop();
    }
}
