using UnityEngine;

public class BearAnimation : MonoBehaviour
{
    public Animator animator;
    public AudioSource sound;

    public void PlaySoundAndAnimation()
    {
        animator.SetTrigger("stand to hind");
        sound.Play();
    }
}