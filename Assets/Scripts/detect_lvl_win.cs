using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detect_lvl_win : MonoBehaviour
{

    public int current_active_child;
    private static detect_lvl_win instance;

    public static detect_lvl_win GetInstance()
    {
        return instance;
    }

    //public VariableScreen_Manager variable_screen_script;

   public List<Transform> child_transform_data;

    private void Awake()
    {
        current_active_child = calulate_parent_child();

        instance = this;
      
    }
    private void Start()
    {
        //this.active_all_child();
        Debug.Log("start called for active child");
        //   PlayerPrefs.SetString("current_lvl_name", this.name);
        //    Debug.Log(PlayerPrefs.GetString("current_lvl_type"));


    }
        

   public int calulate_parent_child()
    {
            int activeChildCount = 0;
            foreach (Transform child in this.transform)
            {
                if (child.gameObject.activeSelf)
                {
                    activeChildCount++;
                }
            child_transform_data.Add(child.transform);

        }


     
        
        Debug.Log(activeChildCount);
        return activeChildCount;
        }
  
    public void active_all_child()
    {
        Debug.Log(current_active_child);
       
        foreach (Transform child in this.transform)
        {
           
            
            child.gameObject.SetActive(true);

        }
        current_active_child = calulate_parent_child();

    }

    public void disable_all_child()
    {
       
        
        foreach (Transform child in this.transform)
        {
            

            child.gameObject.SetActive(false);

        }
        

    }

}

