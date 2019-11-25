using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecivirGolpe : MonoBehaviour
{
    private Animator anim;
    public float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("golpear", 2);
        anim.SetBool("Recieve", false);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Input.GetButton("Fire1") && collision.collider.tag == "Player1")
        {
            anim.SetBool("Recieve", true);
        }

    }

}
