using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplay_pause_screen : MonoBehaviour
{
    private static gameplay_pause_screen instance;

    public static gameplay_pause_screen GetInstance()
    {
        return instance;
    }

    public GameObject pause_screen,gameplay_pause_btn, lvl_screen, selection_screen;
    public bool pause_screen_check = false;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        pause_screen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameplay_screen_btn_clicked()
    {
        pause_screen.SetActive(true);
        gameplay_pause_btn.SetActive(false);
        pause_screen_check = true;
    }

    public void pause_screen_close_btn()
    {
        pause_screen.SetActive(false);
        gameplay_pause_btn.SetActive(true);
        pause_screen_check = false;


    }

    public void pause_screen_back_btn()
    {
        lvl_screen.SetActive(false);
        selection_screen.SetActive(true);
        pause_screen.SetActive(false);
        gameplay_pause_btn.SetActive(true) ;
        pause_screen_check = false;
        MainMenu_UI.GetInstance().MainMenu_AudioSource.Play();

    }
    public void pause_screen_info_btn()
    {
      if(  VariableScreen_Manager.GetInstance().parent.tag=="int_lvl")
        {
            VariableScreen_Manager.GetInstance().int_lvl_guide.SetActive(true);
        }
        if (VariableScreen_Manager.GetInstance().parent.tag == "float_lvl")
        {
            VariableScreen_Manager.GetInstance().float_lvl_guide.SetActive(true);
        }
        if (VariableScreen_Manager.GetInstance().parent.tag == "string_lvl")
        {
            VariableScreen_Manager.GetInstance().string_lvl_guide.SetActive(true);
        }
   pause_screen.SetActive(false);
    
    }
}
