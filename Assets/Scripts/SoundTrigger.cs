using UnityEngine;

// The Audio Source component has an AudioClip option.  The audio
// played in this example comes from AudioClip and is called audioData.
[RequireComponent(typeof(AudioSource))]
public class SoundTrigger : MonoBehaviour
{
    AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
        //audioData.Play(0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        audioData.Play(0);
    }
}