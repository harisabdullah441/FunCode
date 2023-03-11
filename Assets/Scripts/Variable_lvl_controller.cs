using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable_lvl_controller : MonoBehaviour
{
   
    void Start()
    {
        PlayerPrefs.SetString("intro_guide", "completed");
        PlayerPrefs.SetString("int_guide", "notcompleted");
        PlayerPrefs.SetString("float_guide", "notcompleted");
        PlayerPrefs.SetString("string_guide", "notcompleted");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
