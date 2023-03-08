using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variaveis privadas
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    public float horizontalInput;
    public float forwardInput;


    void Start()
    {
      //game
    }

  
    void Update()
    {
        //coletando os inputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //movimentacao
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
