using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class seleccionarPersonaje : MonoBehaviour
{

    public GameObject personaje1;
    public GameObject personaje2;
    public GameObject personaje3;
    public GameObject personaje6;
    public AnimatorController controlador6;
    public AnimatorController controlador2;
    public AnimatorController controlador3;
    public AnimatorController controlador1;

    // Start is called before the first frame update
    void Start()
    {
        activarTodos();
        esconderTodos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void seleccionar(int i)
    {
        PlayerPrefs.SetInt("personaje",i);

        esconderTodos();
        if (i == 2)
        {
            Animator temp = personaje2.GetComponent<Animator>();
            UnityEditor.Animations.AnimatorController.SetAnimatorController(temp,controlador2);
            personaje2.SetActive(true);
        }
        if (i == 3)
        {
            Animator temp = personaje3.GetComponent<Animator>();
            UnityEditor.Animations.AnimatorController.SetAnimatorController(temp, controlador3);
            personaje3.SetActive(true);
        }
        if (i == 1)
        {
            Animator temp = personaje1.GetComponent<Animator>();
            UnityEditor.Animations.AnimatorController.SetAnimatorController(temp, controlador1);
            personaje1.SetActive(true);
        }
        if (i == 6)
        {
            Animator temp = personaje6.GetComponent<Animator>();
            UnityEditor.Animations.AnimatorController.SetAnimatorController(temp, controlador6);
            personaje6.SetActive(true);
        }

    }

    void esconderTodos()
    {        
        personaje1.SetActive(false);
        personaje2.SetActive(false);
        personaje3.SetActive(false);
        personaje6.SetActive(false);
    }

    void activarTodos()
    {
        personaje1.SetActive(true);
        personaje2.SetActive(true);
        personaje3.SetActive(true);
        personaje6.SetActive(true);
    }
}
