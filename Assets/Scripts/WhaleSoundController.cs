using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class WhaleSoundController : MonoBehaviour
{
    public AudioSource WhaleSound;
    public AudioSource WhaleNarration;

    public void OnTargetLost()
    {
        WhaleSound.Stop(); 
        WhaleNarration.Stop();
    }
}
