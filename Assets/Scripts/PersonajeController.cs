using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeController : MonoBehaviour
{
    void Start()
    {
        //GetComponent<Tipo>() para obtener cualquier componente
        //Transform transform=GetComponent<Transform>();
    }

    void Update()
    {
        //dirX toma valores entre -1 y 1
        float dirX = Input.GetAxis("Horizontal");

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(dirX*5, rb.velocity.y);


        if (Input.GetKeyDown("space")) {    // En lugar de "space" se puede usar KeyCode.Space
    GetComponent<Rigidbody2D>().velocity = new Vector2(0, 14);
}
    }
}
