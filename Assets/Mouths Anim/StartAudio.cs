using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAudio : MonoBehaviour
{
    private AudioSource speaker;

    private void Start()
    {
        PlayMethod();
    }

    private void PlayMethod()
    {
        speaker = this.gameObject.GetComponent<AudioSource>();
        speaker.Play(0);
    }
}
