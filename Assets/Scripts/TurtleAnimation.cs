using UnityEngine;

public class TurtleAnimation : MonoBehaviour
{
    public Animator animator;
    public AudioSource sound;

    public void PlaySoundAndAnimation()
    {
        animator.SetTrigger("loggerhead_armature");
        sound.Play();
    }
}