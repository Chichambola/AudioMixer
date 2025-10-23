using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    public void ChangeVolume(float volume)
    {       
        _audioMixerGroup.audioMixer.SetFloat(_audioMixerGroup.ToString(), Mathf.Log10(volume) * 20);
    }

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
