using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void loadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
   public void ExitGame()
    {
        Debug.Log("estoy saliendo");
        Application.Quit();
    }
}
