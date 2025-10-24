using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent (typeof(Slider))]
public class VolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    private const int MinVolume = -80;
    private const int MaxVolume = 20;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(ChangeVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(ChangeVolume);
    }

    public void ChangeVolume(float volume)
    {   
        if(volume == 0)
            _audioMixerGroup.audioMixer.SetFloat(_audioMixerGroup.ToString(), MinVolume);
        else
            _audioMixerGroup.audioMixer.SetFloat(_audioMixerGroup.ToString(), Mathf.Log10(volume) * MaxVolume);
    }
}
