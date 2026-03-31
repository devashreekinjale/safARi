using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class RhinoSoundController : MonoBehaviour
{
    public AudioSource RhinoSound;
    public AudioSource RhinoNarration;

    public void OnTargetLost()
    {
        RhinoSound.Stop(); 
        RhinoNarration.Stop();
    }
}
