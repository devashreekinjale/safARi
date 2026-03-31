using UnityEngine;

public class RhinoAnimation : MonoBehaviour
{
    public Animator animator;
    public AudioSource sound;

    public void PlaySoundAndAnimation()
    {
        animator.SetTrigger("idle");
        sound.Play();
    }
}