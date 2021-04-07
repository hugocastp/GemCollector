using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class CambiarEscena : MonoBehaviour, IPointerClickHandler
{
    public MenuGAZE m;

    public void OnPointerClick(PointerEventData eventData)
     {
        if (m.bosque == true && m.villa == false)
        {
            PantallaDeCarga.Instancia.CargarEscena("Bosque");
        }
        else if (m.villa == true && m.bosque == false)
        {
            PantallaDeCarga.Instancia.CargarEscena("Villa");
        }

    }

   
}


