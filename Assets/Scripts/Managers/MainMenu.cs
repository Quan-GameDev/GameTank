using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Load scene
   public void Play(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

   //Quit game
   public void Quit(){
    Application.Quit();
    Debug.Log("Player has quit the game");
   }
}
