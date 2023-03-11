using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Loading : MonoBehaviour
{

    public GameObject LoadingScreen;
    public Slider LoadingBarFill;
    public float speed;
  



    // Start is called before the first frame update
    void Start()
    {
      //  LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void LoadScene(int sceneId)
    {
        StartCoroutine(LoadSceneAsync(sceneId));

    }


    IEnumerator LoadSceneAsync(int sceneId)
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);

        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / speed);
            LoadingBarFill.value = progressValue;

            yield return null;
        }
    }



}
