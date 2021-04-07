using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScript : MonoBehaviour
{
    public GameObject ObjectToToggle;
    public bool TurnedOn = false;

    private void Start()
    {
        ObjectToToggle.SetActive(TurnedOn);
    }

    public void Toggle()
    {
        if (TurnedOn)
        {
            TurnedOn = false;
        }
        else
        {
            TurnedOn = true;
        }

        ObjectToToggle.SetActive(TurnedOn);
    }

    public void ForceOn()
    {
        ObjectToToggle.SetActive(true);
        TurnedOn = true;
    }

    public void ForceOff()
    {
        ObjectToToggle.SetActive(false);
        TurnedOn = false;
    }
}
