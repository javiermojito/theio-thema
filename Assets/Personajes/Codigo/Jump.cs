using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("saltar", 1);
        anim.SetBool("Salto", false);
    }

    void saltar()
    {
        if (Input.GetButton("Fire2"))
        {
            anim.SetBool("Salto", true);

        }
    }
}
