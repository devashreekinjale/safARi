using UnityEngine;

public class DeerAnimation : MonoBehaviour
{
    public Animator animator;
    public AudioSource sound;

    public void PlaySoundAndAnimation()
    {
        animator.SetTrigger("idle");
        sound.Play();
    }
}