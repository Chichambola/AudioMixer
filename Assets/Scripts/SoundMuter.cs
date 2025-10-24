using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundMuter : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    public void ToggleMute(bool isMuted)
    {
        if (isMuted)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
    }
}
