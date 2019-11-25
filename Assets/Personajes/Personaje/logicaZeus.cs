using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaZeus : MonoBehaviour
{
    // Start is called before the first frame update
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
  
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.transform.position = new Vector3(5.01f, 16.44f, -28.72f);
        }
        if (collision.gameObject.tag == "Player1")
        {
            anim.SetBool("recieve", true);
            Invoke("recievew", 2);
        }
    }
    
    void recievew()
    {
        anim.SetBool("recieve", false);
    }
}
