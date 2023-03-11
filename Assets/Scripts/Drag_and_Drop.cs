using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_and_Drop : MonoBehaviour
{
    private static Drag_and_Drop instance;

    public static Drag_and_Drop GetInstance()
    {
        return instance;
    }

   // public detect_lvl_win detect_lvl_win_script;
   // public VariableScreen_Manager variableScreen_Manager_script;

    public bool dragging, box_trigger;
 
    private Vector2 offset, originalPosition,originalScale;
    public GameObject box;
 //  public GameObject parent;
    public AudioSource source;
        public AudioClip pick_clip,drop_clip;



    private void Awake()
    {
      
        instance = this;
        originalPosition = transform.position;
      //  parent = child.transform.parent.gameObject;
        originalScale = this.transform.localScale;
       
    }
    private void Start()
    {
        source = this.GetComponent<AudioSource>();
       
        Debug.Log("Drag and Drop start parent check");
    }
    private void Update()
    {
        if (!dragging) return;

        var mousePosition = GetMousePos();
        transform.position = mousePosition - offset;
      //  parent = child.transform.parent.gameObject;

    }


    private void OnMouseDown()
    {
       

        if (PlayerPrefs.GetString("intro_guide") == "notcompleted")
        {
            if(this.gameObject.name=="3")
            {
                gameplay_pause_screen.GetInstance().pause_screen_check= false;
            }
            else
            {
                gameplay_pause_screen.GetInstance().pause_screen_check = true;

            }
        }

        if (!gameplay_pause_screen.GetInstance().pause_screen_check)
        {
            dragging = true;
            offset = GetMousePos() - (Vector2)transform.position;
            source.PlayOneShot(pick_clip);
        }


    }
    private void OnMouseUp()
    {

        if (Vector2.Distance(this.transform.position, box.transform.position) < 25f)
        {
            hide_numbers_detect_lvl();
            this.gameObject.SetActive(false);
         
         // this.GetComponent<Animator>().Play("numbers_drop");

        }
        transform.position = originalPosition;
        dragging = false;

        if (!gameplay_pause_screen.GetInstance().pause_screen_check)
        { 
            source.PlayOneShot(drop_clip);
                }

    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public void hide_numbers_detect_lvl()

    {
        //Detecting Int Level
        if (VariableScreen_Manager.GetInstance().parent.tag == "int_lvl")
        {
            if (this.tag == "Int")
            {
               //Detecting int level number

                if(VariableScreen_Manager.GetInstance().parent.name=="int_lvl_1")
                {
                    detect_lvl_win.GetInstance().current_active_child--;
                 
                    if (detect_lvl_win.GetInstance().current_active_child<=8)
                    {
                        VariableScreen_Manager.GetInstance().game_win_window.SetActive(true);
                        gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(false);
                    }
                }

                if (VariableScreen_Manager.GetInstance().parent.name == "int_lvl_2")
                {
                    detect_lvl_win.GetInstance().current_active_child--;

                    if (detect_lvl_win.GetInstance().current_active_child <= 6)
                    {
                        VariableScreen_Manager.GetInstance().game_win_window.SetActive(true);
                        gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(false);

                    }
                }

                if (VariableScreen_Manager.GetInstance().parent.name == "int_lvl_3")
                {
                    detect_lvl_win.GetInstance().current_active_child--;

                    if (detect_lvl_win.GetInstance().current_active_child <= 8)
                    {
                        VariableScreen_Manager.GetInstance().game_win_window.SetActive(true);
                        gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(false);

                    }
                }

            }
            else
            {
                VariableScreen_Manager.GetInstance().game_over_window.SetActive(true);
                detect_lvl_win.GetInstance().disable_all_child(); 
            }
        }

        //Detecting Float Level
        if (VariableScreen_Manager.GetInstance().parent.tag == "float_lvl")
        {
            if (this.tag == "float")
            {
                if (VariableScreen_Manager.GetInstance().parent.name == "float_lvl_1")
                {
                    detect_lvl_win.GetInstance().current_active_child--;

                    if (detect_lvl_win.GetInstance().current_active_child <= 7)
                    {
                        VariableScreen_Manager.GetInstance().game_win_window.SetActive(true);
                        gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(false);
                    }
                }

                if (VariableScreen_Manager.GetInstance().parent.name == "float_lvl_2")
                {
                    detect_lvl_win.GetInstance().current_active_child--;

                    if (detect_lvl_win.GetInstance().current_active_child <= 9)
                    {
                        VariableScreen_Manager.GetInstance().game_win_window.SetActive(true);
                        gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(false);
                    }
                }

                if (VariableScreen_Manager.GetInstance().parent.name == "float_lvl_3")
                {
                    detect_lvl_win.GetInstance().current_active_child--;

                    if (detect_lvl_win.GetInstance().current_active_child <= 7)
                    {
                        VariableScreen_Manager.GetInstance().game_win_window.SetActive(true);
                        gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(false);
                    }
                }





            }
            else
            {
                VariableScreen_Manager.GetInstance().game_over_window.SetActive(true);
                detect_lvl_win.GetInstance().disable_all_child();
            }
        }


        //Detecting String Level
        if (VariableScreen_Manager.GetInstance().parent.tag == "string_lvl")
        {
            if (this.tag == "string")
            {
                if (VariableScreen_Manager.GetInstance().parent.name == "string_lvl_1")
                {
                    detect_lvl_win.GetInstance().current_active_child--;

                    if (detect_lvl_win.GetInstance().current_active_child <= 8)
                    {
                        VariableScreen_Manager.GetInstance().game_win_window.SetActive(true);
                        gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(false);
                    }
                }
                if (VariableScreen_Manager.GetInstance().parent.name == "string_lvl_2")
                {
                    detect_lvl_win.GetInstance().current_active_child--;

                    if (detect_lvl_win.GetInstance().current_active_child <= 10)
                    {
                        VariableScreen_Manager.GetInstance().game_win_window.SetActive(true);
                        gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(false);
                    }
                }
                if (VariableScreen_Manager.GetInstance().parent.name == "string_lvl_3")
                {
                    detect_lvl_win.GetInstance().current_active_child--;

                    if (detect_lvl_win.GetInstance().current_active_child <= 7)
                    {
                        VariableScreen_Manager.GetInstance().game_win_window.SetActive(true);
                        gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(false);
                    }
                }
            }
            else
            {
                VariableScreen_Manager.GetInstance().game_over_window.SetActive(true);
                detect_lvl_win.GetInstance().disable_all_child();
            }
        }
        this.gameObject.SetActive(false);
        this.transform.position = originalPosition;
        this.transform.localScale = originalScale;

        // Detecting if 3 is stored

        if (PlayerPrefs.GetString("intro_guide") == "notcompleted")
        {
            if (this.gameObject.name == "3")
            {
                PlayerPrefs.SetString("intro_guide", "completed");

               VariableScreen_Manager.GetInstance(). guide_hand.SetActive(false);
                VariableScreen_Manager.GetInstance().guide_block.SetActive(false);
                
                gameplay_pause_screen.GetInstance().pause_screen_check = false;
                gameplay_pause_screen.GetInstance().gameplay_pause_btn.SetActive(true);

                Debug.Log(PlayerPrefs.GetString("intro_guide"));

            }
           
        }

    }


}
    