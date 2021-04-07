using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMngr : MonoBehaviour
{

    public void LoadBosque()
    {
      SceneManager.LoadScene("Bosque");
    }
    
    public void LoadVilla()
    {
        SceneManager.LoadScene("Villa");
    }

    public void LoadMenu()
    {
      
       SceneManager.LoadScene("Menu");
    }
  
    
}