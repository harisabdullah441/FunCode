using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_Drop_Audio : MonoBehaviour
{
    private static Drag_Drop_Audio instance;
     public AudioSource audioSource;
    public AudioClip pick_clip, drop_clip;
    private void Awake()
    {
        instance = this;
    }

    public static Drag_Drop_Audio GetInstance()
    {
        return instance;
    }
}
