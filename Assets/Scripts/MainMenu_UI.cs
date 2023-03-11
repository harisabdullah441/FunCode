using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu_UI : MonoBehaviour
{
    private static MainMenu_UI instance;

    public static MainMenu_UI GetInstance()
    {
        return instance;
    }



    public GameObject MainMenu_Screen, Setting_Screen, sound_On_btn, sound_Off_btn;
    public AudioSource MainMenu_AudioSource;
    public Slider Volume;
   
    private void Awake()
    {
       MainMenu_AudioSource = GameObject.Find("Menu_Audio").GetComponent<AudioSource>();
        instance = this;


    }
    void Start()
    {
        MainMenu_Screen.SetActive(true);
        Setting_Screen.SetActive(false);
      
            LoadSound_settings();
     
    }


   

    public void setting_btn_clicked()
    {
    MainMenu_Screen.SetActive(false);
        Setting_Screen.SetActive(true);
    }
    public void back_btn_clicked()
    {
        MainMenu_Screen.SetActive(true);
        Setting_Screen.SetActive(false);
    }
    public void soundOn_btn_clicked()
    {
        sound_On_btn.SetActive(false);
        sound_Off_btn.SetActive(true);
       MainMenu_AudioSource.Stop();
        PlayerPrefs.SetString("Sound", "Off");
    }
    public void soundOff_btn_clicked()
    {
        sound_Off_btn.SetActive(false);
        sound_On_btn.SetActive(true);
        MainMenu_AudioSource.Play();
        PlayerPrefs.SetString("Sound", "On");

    }
    public void VolumeSlider()
    {
         MainMenu_AudioSource.volume = Volume.value;
        PlayerPrefs.SetFloat("AudioVolume", Volume.value);
    }
    public void LoadSound_settings()
    {
        MainMenu_AudioSource.volume = PlayerPrefs.GetFloat("AudioVolume", 1);
        Volume.value = PlayerPrefs.GetFloat("AudioVolume", 1);
      if(PlayerPrefs.GetString("Sound","On")=="On")
        {
            soundOff_btn_clicked();
        }
      else
        {
            soundOn_btn_clicked();
        }
    }
  
    public void variable_btn_clicked()
    {
        SceneManager.LoadScene(2);
     
    }
    public void conditional_btn_clicked()
    {
        SceneManager.LoadScene(3);
    }
    public void loop_btn_clicked()
    {
        SceneManager.LoadScene(4);
    }
}
