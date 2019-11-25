using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cargarRecursos : MonoBehaviour
{
    public GameObject sprtPersonaje;
    public GameObject power1;
    public GameObject power2;
    public GameObject power3;
    public GameObject power4;
    public Sprite personaje1;
    public Sprite personaje1power1;
    public Sprite personaje1power2;
    public Sprite personaje1power3;
    public Sprite personaje1power4;
    public Sprite personaje2;
    public Sprite personaje2power1;
    public Sprite personaje2power2;
    public Sprite personaje2power3;
    public Sprite personaje2power4;
    public Sprite personaje3;
    public Sprite personaje3power1;
    public Sprite personaje3power2;
    public Sprite personaje3power3;
    public Sprite personaje3power4;
    public Sprite personaje4;
    public Sprite personaje4power1;
    public Sprite personaje4power2;
    public Sprite personaje4power3;
    public Sprite personaje4power4;
    public Sprite personaje5;
    public Sprite personaje5power1;
    public Sprite personaje5power2;
    public Sprite personaje5power3;
    public Sprite personaje5power4;
    public Sprite personaje6;
    public Sprite personaje6power1;
    public Sprite personaje6power2;
    public Sprite personaje6power3;
    public Sprite personaje6power4;

    public GameObject modelo1;
    public GameObject modelo2;
    public GameObject modelo3;
    public GameObject modelo6;
    public GameObject camera1;


    // Start is called before the first frame update
    void Start()
    {
        //esconderTodos();

        int numPersonaje = PlayerPrefs.GetInt("personaje");
        if (numPersonaje==1)
        {
            modelo1.SetActive(true);
            sprtPersonaje.GetComponent<Image>().overrideSprite = personaje1;
            power1.GetComponent<Image>().overrideSprite = personaje1power1;
            power2.GetComponent<Image>().overrideSprite = personaje1power2;
            power3.GetComponent<Image>().overrideSprite = personaje1power3;
            power4.GetComponent<Image>().overrideSprite = personaje1power4;
        }
        else if (numPersonaje == 2)
        {
            modelo2.SetActive(true);
            sprtPersonaje.GetComponent<Image>().overrideSprite = personaje2;
            power1.GetComponent<Image>().overrideSprite = personaje2power1;
            power2.GetComponent<Image>().overrideSprite = personaje2power2;
            power3.GetComponent<Image>().overrideSprite = personaje2power3;
            power4.GetComponent<Image>().overrideSprite = personaje2power4;
        }
        else if (numPersonaje == 3)
        {
            modelo3.SetActive(true);
            sprtPersonaje.GetComponent<Image>().overrideSprite = personaje3;
            power1.GetComponent<Image>().overrideSprite = personaje3power1;
            power2.GetComponent<Image>().overrideSprite = personaje3power2;
            power3.GetComponent<Image>().overrideSprite = personaje3power3;
            power4.GetComponent<Image>().overrideSprite = personaje3power4;
        }
        else if (numPersonaje == 4)
        {
            sprtPersonaje.GetComponent<Image>().overrideSprite = personaje4;
            power1.GetComponent<Image>().overrideSprite = personaje4power1;
            power2.GetComponent<Image>().overrideSprite = personaje4power2;
            power3.GetComponent<Image>().overrideSprite = personaje4power3;
            power4.GetComponent<Image>().overrideSprite = personaje4power4;
        }
        else if (numPersonaje == 5)
        {
            sprtPersonaje.GetComponent<Image>().overrideSprite = personaje5;
            power1.GetComponent<Image>().overrideSprite = personaje5power1;
            power2.GetComponent<Image>().overrideSprite = personaje5power2;
            power3.GetComponent<Image>().overrideSprite = personaje5power3;
            power4.GetComponent<Image>().overrideSprite = personaje5power4;
        }
        else if (numPersonaje == 6)
        {
            modelo6.SetActive(true); 
            sprtPersonaje.GetComponent<Image>().overrideSprite = personaje6;
            power1.GetComponent<Image>().overrideSprite = personaje6power1;
            power2.GetComponent<Image>().overrideSprite = personaje6power2;
            power3.GetComponent<Image>().overrideSprite = personaje6power3;
            power4.GetComponent<Image>().overrideSprite = personaje6power4;
        }

        camera1.SetActive(false);
    }

    public void esconderTodos()
    {
        modelo1.SetActive(false);
        modelo2.SetActive(false);
        modelo3.SetActive(false);
        modelo6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
