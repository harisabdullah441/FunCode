using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VariableScreen_Manager : MonoBehaviour
{
    private static VariableScreen_Manager instance;

    public static VariableScreen_Manager GetInstance()
    {
        return instance;
    }


    public GameObject guide_hand, guide_block, int_lvl_guide, float_lvl_guide, string_lvl_guide ,Variable_type_Screen, int_lvl_screen, float_lvl_screen, string_lvl_screen, game_win_window, game_over_window;
    public GameObject int_lvl_1, int_lvl_2, int_lvl_3, float_lvl_1, float_lvl_2, float_lvl_3, string_lvl_1, string_lvl_2, string_lvl_3 ;
    public GameObject parent;
    public Animator guide_hand_animator;
  //  public Drag_and_Drop drag_and_drop_script;
    //public detect_lvl_win detect_Lvl_Win_script;

    private void Awake()
    {
        instance= this;
    }

    void Start()
    {
        initialScreen_setup();

       
    }


    // Update is called once per frame
    private void Update()
    {
       // Debug.Log(Drag_and_Drop.GetInstance().parent.name);

    }
    private void initialScreen_setup()
    {
        Variable_type_Screen.SetActive(true);
        int_lvl_screen.SetActive(false);
        float_lvl_screen.SetActive(false);
        string_lvl_screen.SetActive(false);
        PlayerPrefs.DeleteKey("current_lvl_type");
       


    }
    public void int_btn_clicked()
    {
        Variable_type_Screen.SetActive(false);
        int_lvl_screen.SetActive(true);
    }
    public void float_btn_clicked()
    {
        Variable_type_Screen.SetActive(false);
        float_lvl_screen.SetActive(true);
    }
    public void string_btn_clicked()
    {
        Variable_type_Screen.SetActive(false);
        string_lvl_screen.SetActive(true);
    }
    public void back_btn_clicked()
    {
        initialScreen_setup();
        
    }
    public void Menu_back_btn()
        {
        SceneManager.LoadScene(1);
    }



   public void int_lvl_1_btn()
    {
        int_lvl_1.SetActive(true);
        int_lvl_screen.SetActive(false);
     //  detect_lvl_win.GetInstance().active_all_child();
      //  gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(true);
        MainMenu_UI.GetInstance().MainMenu_AudioSource.Stop();
        PlayerPrefs.SetString("current_lvl_type", "int_lvl");
        parent = int_lvl_1.gameObject;
        //    Drag_and_Drop.GetInstance().parent = int_lvl_1.gameObject;
        //   Debug.Log(Drag_and_Drop.GetInstance().parent.name);
        parent.GetComponent<detect_lvl_win>().active_all_child();
       parent.GetComponent<gameplay_pause_screen>().gameplay_pause_btn.SetActive(true);
        Debug.Log(parent.name);
      if(PlayerPrefs.GetString("int_guide") == "notcompleted")
        {
            int_lvl_guide.SetActive(true) ;
            gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(false);
            parent.GetComponent<detect_lvl_win>().disable_all_child();
        }
       
    }

    public void int_lvl_2_btn()
    {
        int_lvl_2.SetActive(true);
        int_lvl_screen.SetActive(false);
        detect_lvl_win.GetInstance().active_all_child();
        gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(true);
        MainMenu_UI.GetInstance().MainMenu_AudioSource.Stop();
        PlayerPrefs.SetString("current_lvl_type", "int_lvl");
        parent = int_lvl_2.gameObject;
        parent.GetComponent<detect_lvl_win>().active_all_child();
        parent.GetComponent<gameplay_pause_screen>().gameplay_pause_btn.SetActive(true);
        //  Drag_and_Drop.GetInstance().parent = Drag_and_Drop.GetInstance().transform.parent.gameObject;
        // Drag_and_Drop.GetInstance().parent = int_lvl_2.gameObject;


    }


    public void int_lvl_3_btn()
    {
        int_lvl_3.SetActive(true);
        int_lvl_screen.SetActive(false);
        detect_lvl_win.GetInstance().active_all_child();
        gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(true);
        MainMenu_UI.GetInstance().MainMenu_AudioSource.Stop();
        PlayerPrefs.SetString("current_lvl_type", "int_lvl");
        parent = int_lvl_3.gameObject;
        parent.GetComponent<detect_lvl_win>().active_all_child();
        parent.GetComponent<gameplay_pause_screen>().gameplay_pause_btn.SetActive(true);
        //  Drag_and_Drop.GetInstance().parent = Drag_and_Drop.GetInstance().transform.parent.gameObject;
        // Drag_and_Drop.GetInstance().parent = int_lvl_2.gameObject;


    }

    public void float_lvl_1_btn()
    {
        float_lvl_1.SetActive(true);
        float_lvl_screen.SetActive(false);
        //  detect_lvl_win.GetInstance().active_all_child();
        //  gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(true);
        MainMenu_UI.GetInstance().MainMenu_AudioSource.Stop();
        PlayerPrefs.SetString("current_lvl_type", "float_lvl");
        parent = float_lvl_1.gameObject;
        //    Drag_and_Drop.GetInstance().parent = int_lvl_1.gameObject;
        //   Debug.Log(Drag_and_Drop.GetInstance().parent.name);
        parent.GetComponent<detect_lvl_win>().active_all_child();
        parent.GetComponent<gameplay_pause_screen>().gameplay_pause_btn.SetActive(true);
       
        if (PlayerPrefs.GetString("float_guide") == "notcompleted")
        {
            float_lvl_guide.SetActive(true);
            gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(false);
            parent.GetComponent<detect_lvl_win>().disable_all_child();
        }
    }


    public void float_lvl_2_btn()
    {
        float_lvl_2.SetActive(true);
        float_lvl_screen.SetActive(false);
        detect_lvl_win.GetInstance().active_all_child();
        gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(true);
        MainMenu_UI.GetInstance().MainMenu_AudioSource.Stop();
        PlayerPrefs.SetString("current_lvl_type", "float_lvl");
        parent = float_lvl_2.gameObject;
        parent.GetComponent<detect_lvl_win>().active_all_child();
        parent.GetComponent<gameplay_pause_screen>().gameplay_pause_btn.SetActive(true);
    }

    public void float_lvl_3_btn()
    {
        float_lvl_3.SetActive(true);
        float_lvl_screen.SetActive(false);
        detect_lvl_win.GetInstance().active_all_child();
        gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(true);
        MainMenu_UI.GetInstance().MainMenu_AudioSource.Stop();
        PlayerPrefs.SetString("current_lvl_type", "float_lvl");
        parent = float_lvl_3.gameObject;
        parent.GetComponent<detect_lvl_win>().active_all_child();
        parent.GetComponent<gameplay_pause_screen>().gameplay_pause_btn.SetActive(true);
    }



    public void string_lvl_1_btn()
    {
        string_lvl_1.SetActive(true);
        string_lvl_screen.SetActive(false);
        //  detect_lvl_win.GetInstance().active_all_child();
        //  gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(true);
        MainMenu_UI.GetInstance().MainMenu_AudioSource.Stop();
        PlayerPrefs.SetString("current_lvl_type", "string_lvl");
        parent = string_lvl_1.gameObject;
        //    Drag_and_Drop.GetInstance().parent = int_lvl_1.gameObject;
        //   Debug.Log(Drag_and_Drop.GetInstance().parent.name);
        parent.GetComponent<detect_lvl_win>().active_all_child();
        parent.GetComponent<gameplay_pause_screen>().gameplay_pause_btn.SetActive(true);

        if (PlayerPrefs.GetString("string_guide") == "notcompleted")
        {
            string_lvl_guide.SetActive(true);
            gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(false);
            parent.GetComponent<detect_lvl_win>().disable_all_child();
        }
    }


    public void string_lvl_2_btn()
    {
        string_lvl_2.SetActive(true);
        string_lvl_screen.SetActive(false);
        detect_lvl_win.GetInstance().active_all_child();
        gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(true);
        MainMenu_UI.GetInstance().MainMenu_AudioSource.Stop();
        PlayerPrefs.SetString("current_lvl_type", "string_lvl");
        parent = string_lvl_2.gameObject;
        parent.GetComponent<detect_lvl_win>().active_all_child();
        parent.GetComponent<gameplay_pause_screen>().gameplay_pause_btn.SetActive(true);
    }

    public void string_lvl_3_btn()
    {
        string_lvl_3.SetActive(true);
        string_lvl_screen.SetActive(false);
        detect_lvl_win.GetInstance().active_all_child();
        gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(true);
        MainMenu_UI.GetInstance().MainMenu_AudioSource.Stop();
        PlayerPrefs.SetString("current_lvl_type", "string_lvl");
        parent = string_lvl_3.gameObject;
        parent.GetComponent<detect_lvl_win>().active_all_child();
        parent.GetComponent<gameplay_pause_screen>().gameplay_pause_btn.SetActive(true);
    }


    // Game_Win Window Settings

    public void game_win_window_setting_check()
    {
        if(PlayerPrefs.GetString("current_lvl_type")=="int_lvl")
        {
            int_lvl_screen.SetActive(true);
            game_win_window.SetActive(false);
            VariableScreen_Manager.GetInstance().parent.SetActive(false);

        }
        if (PlayerPrefs.GetString("current_lvl_type") == "float_lvl")
        {
            float_lvl_screen.SetActive(true);
            game_win_window.SetActive(false);
            VariableScreen_Manager.GetInstance().parent.SetActive(false);

        }
        if (PlayerPrefs.GetString("current_lvl_type") == "string_lvl")
        {
            float_lvl_screen.SetActive(true);
            game_win_window.SetActive(false);
            VariableScreen_Manager.GetInstance().parent.SetActive(false);

        }

        MainMenu_UI.GetInstance().MainMenu_AudioSource.Play();

    }

    public void game_over_window_reset_btn()
    {
        game_over_window.SetActive(false);
        parent.GetComponent<detect_lvl_win>().active_all_child();
    
    }
    public void game_over_window_back_btn()
    {
        if (parent.tag == "int_lvl")
        {
            int_lvl_screen.SetActive(true);
            game_over_window.SetActive(false);
            VariableScreen_Manager.GetInstance().parent.SetActive(false);

        }
        if (parent.tag == "float_lvl")
        {
            float_lvl_screen.SetActive(true);
            game_over_window.SetActive(false);
            VariableScreen_Manager.GetInstance().parent.SetActive(false);

        }
        if (parent.tag == "string_lvl")
        {
            float_lvl_screen.SetActive(true);
            game_over_window.SetActive(false);
            VariableScreen_Manager.GetInstance().parent.SetActive(false);

        }
        parent.GetComponent<detect_lvl_win>().active_all_child();
    }

    public void guide_close_btn()
    {
        if (parent.tag == "int_lvl")
        {
            int_lvl_guide.SetActive(false);
            gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(true);

            if (PlayerPrefs.GetString("int_guide") == "completed")
            {
                gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(true);
                gameplay_pause_screen.GetInstance().pause_screen_check = false;
            }


            if (PlayerPrefs.GetString("int_guide") == "notcompleted")
            {
                PlayerPrefs.SetString("int_guide", "completed");
                parent.GetComponent<detect_lvl_win>().active_all_child();
            }
                
                if (PlayerPrefs.GetString("intro_guide") == "notcompleted")
            {
                guide_hand.SetActive(true);
                guide_block.SetActive(true);
                guide_hand_animator.Play("guide_hand");
                gameplay_pause_screen.GetInstance().pause_screen_check = true;
                gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(false);


            }
               

        }
        if (parent.tag == "float_lvl")
        {
            float_lvl_guide.SetActive(false);
           
             

            if (PlayerPrefs.GetString("float_guide") == "notcompleted")
            {
                PlayerPrefs.SetString("float_guide", "completed");
                parent.GetComponent<detect_lvl_win>().active_all_child();
            }
            gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(true);
            gameplay_pause_screen.GetInstance().pause_screen_check = false;



        }
        if (parent.tag == "string_lvl")
        {
        string_lvl_guide.SetActive(false);
            if (PlayerPrefs.GetString("string_guide") == "notcompleted")
            {
                PlayerPrefs.SetString("float_guide", "completed");
                parent.GetComponent<detect_lvl_win>().active_all_child();
            }
            gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(true);
            gameplay_pause_screen.GetInstance().pause_screen_check = false;

        }




    }

}
