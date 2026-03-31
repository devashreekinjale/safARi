using UnityEngine;

public class ElephantAnimation : MonoBehaviour
{
    public Animator animator;
    public AudioSource sound;

    public void PlaySoundAndAnimation()
    {
        animator.SetTrigger("Roar");
        sound.Play();
    }
}