using UnityEngine;

public class TigerAnimation : MonoBehaviour
{
    public Animator animator;
    public AudioSource sound;

    public void PlaySoundAndAnimation()
    {
        animator.SetTrigger("Howl");
        sound.Play();
    }
}