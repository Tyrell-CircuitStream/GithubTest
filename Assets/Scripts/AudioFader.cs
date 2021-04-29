using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFader : MonoBehaviour
{
    [Header("Scene References")]
    public AudioSource rightAudioSource;
    public AudioSource leftAudioSource;

    [Space(50)]

    [Range(0,1)]
    public float fadeControl = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rightAudioSource.volume = fadeControl;
        leftAudioSource.volume = 1 - fadeControl;
    }
}
