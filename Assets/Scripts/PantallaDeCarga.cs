using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR;
public class PantallaDeCarga : MonoBehaviour {
    
    public static PantallaDeCarga Instancia { get; private set; }
    public GameObject pantallacarga;
    public Image imageDeCarga;
    [Range(0.01f, 0.1f)]
    public float velocidadAparecer = 0.5f;
    [Range(0.01f, 0.1f)]
    public float velocidadOcultar = 0.5f;

    void Awake()
    {
        DefinirSingleton();
       
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

    private void DefinirSingleton()
    {
        if (Instancia == null)
        {
            Instancia = this;
            DontDestroyOnLoad(this);
            imageDeCarga.gameObject.SetActive(false);

        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CargarEscena(string nombreEscena)
    {
        StartCoroutine(MostrarPantallaDeCarga(nombreEscena));
    }
    

    private IEnumerator MostrarPantallaDeCarga(string nombreEscena)
    {
        Restart();
        int y;
       
        DisableVR();
        imageDeCarga.gameObject.SetActive(true);
        //DisableVR();
        Color c = imageDeCarga.color;
        float x = 0.1f;
        c.a = 1f;

        
        //Mientras no esté totalmente visible va aumentando su visibilidad
        while (x < 1f)
        {
            imageDeCarga.color = c;
            x += velocidadAparecer;
            yield return null;
        }
       

        //Carga la escena
        SceneManager.LoadSceneAsync(nombreEscena);
        EnableVR();
        yield return new WaitForSeconds(2);
        
        Destroy(pantallacarga);
       /* pantallacarga.GetComponent<PantallaDeCarga>().enabled = false;
        imageDeCarga.gameObject.SetActive(false);
        Destroy(pantallacarga);*/
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
