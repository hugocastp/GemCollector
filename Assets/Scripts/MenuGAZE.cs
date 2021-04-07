using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuGAZE : MonoBehaviour
{

    public bool bosque;
    public bool villa;
 

    public void EnterBotonBosque()
    {
        bosque = true;
    }
    public void ExitBotonBosque()
    {
        bosque = false;
    }

    public void EnterBotonVilla()
    {
        villa = true;
    }
    public void ExitBotonVilla()
    {
        villa = false;
    }



}