using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    

    void Start()
    {
        turnSpeed = 45.0f;
    }
    public float speed = 20.0f;
    public float turnSpeed = 45.0f;
    public float horizontalInput;
    public float forwardInput;
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward*Time.deltaTime*speed * forwardInput);
        transform.Rotate(Vector3.up,turnSpeed*horizontalInput*Time.deltaTime);
        

        


    }

}
