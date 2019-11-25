using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje1 : MonoBehaviour
{
    public KeyCode ata;
    public float velocidadMovimiento = 0.5f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x, y, z;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
    
        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        Invoke("atacar", 2);
        anim.SetBool("Hit", false);

        Invoke("saltar", 1);
        anim.SetBool("Salto", false);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);


    }

    void saltar()
    {
        if (Input.GetButton("Jump"))
        {
            anim.SetBool("Salto", true);

        }
    }

    void atacar()
    {
        if (Input.GetKey(ata))
        {
            anim.SetBool("Hit", true);
        }
    }
}
