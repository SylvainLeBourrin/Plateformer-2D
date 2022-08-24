using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public GameObject Creation_Du_Personnage;
    private float Speed = 20.0f;

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {

            transform.Translate(Vector3.forward * Speed);
            Debug.Log("Hello: " + gameObject.name);
        }

    }
}
