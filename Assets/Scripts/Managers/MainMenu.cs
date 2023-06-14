using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;

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

    [SerializeField] private string gamePlaySceneName = "Gameplay";
   public void StartHost(){
        NetworkManager.Singleton.StartHost();
        NetworkManager.Singleton.SceneManager.LoadScene(gamePlaySceneName, LoadSceneMode.Single);
   }

   public void StartServer(){
        NetworkManager.Singleton.StartServer();
        NetworkManager.Singleton.SceneManager.LoadScene(gamePlaySceneName, LoadSceneMode.Single);
   }

   public void StartClient(){
        NetworkManager.Singleton.StartClient();
   }
}
