using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaAforidta : MonoBehaviour
{
    // Start is called before the first frame update
    public KeyCode ata;
    public float velocidadMovimiento = 0.5f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x, y, z;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        atacar();  
    }

    void parar()
    {
        anim.SetBool("hit", false);

    }
    void atacar()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            anim.SetBool("hit", true);
            Invoke("parar", 1);

        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "reiniciar")
        {
            anim.transform.position = new Vector3(5.01f,16.44f,-28.72f);
        }

    }
}
