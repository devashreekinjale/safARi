using UnityEngine;

public class DolphinAnimation : MonoBehaviour
{
    public Animator animator;
    public AudioSource sound;

    public void PlaySoundAndAnimation()
    {
        animator.SetTrigger("Scene 0");
        sound.Play();
    }
}