using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class TurtleSoundController : MonoBehaviour
{
    public AudioSource TurtleSound;
    public AudioSource TurtleNarration;

    public void OnTargetLost()
    {
        TurtleSound.Stop(); 
        TurtleNarration.Stop();
    }
}
