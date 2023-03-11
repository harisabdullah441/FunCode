using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy_Audio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private static DoNotDestroy_Audio instance = null;
    public static DoNotDestroy_Audio Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}