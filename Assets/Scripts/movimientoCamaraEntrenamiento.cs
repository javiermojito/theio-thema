using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoCamaraEntrenamiento : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);

        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0,speed*Time.deltaTime*7));
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0,speed * Time.deltaTime * -7));
        }



    }
}
