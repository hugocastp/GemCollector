using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
public class ScriptA : MonoBehaviour
{
    //Puntuación
    public Text win;
    public static int Score = 0;
    public Text puntuacion;
    //reloj
    public Text contadorTime;
    public float tiempo = 60f;
    //pause 
    bool active;
    

    void Start()
    {
        //EnableVR();
        active = false;
        //reloj
        contadorTime.text = " " + tiempo;
        //marcador
        Score = 0;
        OnGUI();
        win.gameObject.SetActive(false);
        //pause
        Time.timeScale = (active) ? 0 : 0.9f;

    }
    IEnumerator LoadDevice(string newDevice, bool enable)
    {
        XRSettings.LoadDeviceByName(newDevice);
        yield return null;
        XRSettings.enabled = enable;
    }

    void EnableVR()
    {
        StartCoroutine(LoadDevice("cardboard", true));
    }

    void DisableVR()
    {
        StartCoroutine(LoadDevice("", false));
    }


    // Update is called once per frame
    void Update()
    {
        //reloj
        tiempo -= Time.deltaTime;
        contadorTime.text = " " + tiempo.ToString("f0");
            if (Score >= 5 && tiempo != 0)
            {
                Cursor.visible = true;
                win.text = "¡Ganaste!";
                win.gameObject.SetActive(true);
                Time.timeScale = (active) ? 0 : 0f;//congelar
        }
        if (tiempo <= 0)
        {
            Cursor.visible = true;
            contadorTime.text = "0";
            win.text = "Se acabó el tiempo";
            win.gameObject.SetActive(true);
            Time.timeScale = (active) ? 0 : 0f;

        }

    }

     void OnGUI()
    {
        puntuacion.text = "Diamantes encontrados: " +Score.ToString();
    }


}

