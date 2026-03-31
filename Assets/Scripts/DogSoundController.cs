using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class DogSoundController : MonoBehaviour
{
    public AudioSource DogSound;
    public AudioSource DogNarration;

    public void OnTargetLost()
    {
        DogSound.Stop(); 
        DogNarration.Stop();
    }
}
