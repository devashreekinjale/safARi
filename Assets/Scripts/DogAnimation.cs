using UnityEngine;

public class DogAnimation : MonoBehaviour
{
    public Animator animator;
    public AudioSource sound;

    public void PlaySoundAndAnimation()
    {
        animator.SetTrigger("labrador_idle_bark_04_warning");
        sound.Play();
    }
}