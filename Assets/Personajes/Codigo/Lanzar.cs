using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanzar : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody bala;
    public Transform lanzador;
    public float velDisparo, tiempoDisparo;
    private float inicioDisparar;
    public KeyCode disparo;

    void Start()
    {
            inicioDisparar = Time.time + tiempoDisparo;
            Rigidbody balaInstant;

            balaInstant = Instantiate(bala, lanzador.position, Quaternion.identity);
            balaInstant.AddForce(lanzador.forward * 100 * velDisparo);
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
