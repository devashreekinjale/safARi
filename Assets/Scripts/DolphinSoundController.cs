using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class DolphinSoundController : MonoBehaviour
{
    public AudioSource DolphinSound;
    public AudioSource DolphinNarration;

    public void OnTargetLost()
    {
        DolphinSound.Stop(); 
        DolphinNarration.Stop();
    }
}
