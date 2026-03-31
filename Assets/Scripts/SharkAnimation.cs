using UnityEngine;

public class SharkAnimation : MonoBehaviour
{
    public Animator animator;
    public AudioSource sound;

    public void PlaySoundAndAnimation()
    {
        animator.SetTrigger("bite");
        sound.Play();
    }
}