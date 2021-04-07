using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class CambiarVilla : MonoBehaviour, IPointerClickHandler
{
    public MenuGAZE m;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (m.villa == true && m.bosque == false)
        {
            PantallaDeCarga.Instancia.CargarEscena("Villa");
        }
        else if (m.bosque == true && m.villa == false)
        {
            PantallaDeCarga.Instancia.CargarEscena("Bosque");
        }

    }


}

