using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mostrarPanelOpciones : MonoBehaviour
{

    public GameObject panel;


    public void mostrarPanel()
    {
        if (panel != null)
        {
            panel.SetActive(!panel.activeSelf);
        }
        
    }
}
