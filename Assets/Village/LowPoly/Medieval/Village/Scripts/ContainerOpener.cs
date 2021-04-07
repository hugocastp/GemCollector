using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerOpener : MonoBehaviour
{
    public bool IsOpened = true;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
        if (IsOpened)
        {
            animator.SetBool("Opened", IsOpened);
        }
    }

  
    public void Open()
    {
        animator.SetBool("Opened", true);
        IsOpened = true; 
    }

    public void Close()
    {
        animator.SetBool("Opened", false);
        IsOpened = false;
    }

    public void Toggle()
    {
        if (IsOpened)
        {
            Close();
        }
        else
        {
            Open();
        }
    }
}
