using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarPoderes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown("m"))
        {
            Debug.Log("M - para hacerse daño.");
        }
    }
}
