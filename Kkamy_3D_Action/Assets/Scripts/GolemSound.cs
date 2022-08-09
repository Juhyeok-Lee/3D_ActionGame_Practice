using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemSound : MonoBehaviour
{
    AudioSource playAudio;

    public AudioClip walk;
    public AudioClip swingA;
    public AudioClip swingB;
    
    void Start()
    {
        playAudio = GetComponent<AudioSource>();
    }
        
    void Walk()
    {
        playAudio.clip = walk;
        playAudio.Play();
    }

    void SwingA()
    {
        playAudio.clip = swingA;
        playAudio.Play();
    }

    void SwingB()
    {
        playAudio.clip = swingB;
        playAudio.Play();
    }
}
