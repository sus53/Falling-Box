using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public static bool disabled = false;

    public void PlayGame(){
       SceneManager.LoadScene("PlayerSelection");
    }

    public void Player1(){
       SceneManager.LoadScene("Player1");
    }

    public void Player2(){
       SceneManager.LoadScene("Player2");
    }

    public void QuitGame(){
       Application.Quit();
    }

    public void back(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    

     
   
}
