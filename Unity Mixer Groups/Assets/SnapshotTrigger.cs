using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SnapshotTrigger : MonoBehaviour
{
    public AudioMixerSnapshot dayTime;
    public AudioMixerSnapshot nightTime;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            nightTime.TransitionTo(0f);
        }


    }

    private void OnTriggerStay(Collider other)
    { 
    
        if (other.CompareTag("MainCamera"))
        {
            nightTime.TransitionTo(0f);
        }

    }





}
