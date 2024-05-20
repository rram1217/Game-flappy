using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private int pauseFlag = 0;
    public void start(){
        SceneManager.LoadScene(1);
    }

    public void quit(){
        Application.Quit();
    }

    public void pause(){
        // SceneManager.LoadScene(0);
        Time.timeScale = 0;
        pauseFlag = 1;
        // GameObject.FindGameObjectWithTag("ButtonPlay").SetActive(true);
        // GameObject.FindGameObjectWithTag("ButtonPause").GetComponent<Button>().enabled = false; // SetActive(false);
    }
    
    public void play(){
        // SceneManager.LoadScene(0);
        Time.timeScale = 1;
        pauseFlag = 0;
        // GameObject.FindGameObjectWithTag("ButtonPause").SetActive(true);
        // GameObject.FindGameObjectWithTag("ButtonPlay").GetComponent<Button>().enabled = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.P))
        {
            if(pauseFlag == 0){
                Debug.Log("tiempo 1");
                pause();
            }else{
                Debug.Log("tiempo 0");
                play();
            }
        }
    }


}
