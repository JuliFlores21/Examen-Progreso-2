using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float trackSpeed = 10f;
    public float grassSpeed = 5f;
    public float rotationSpeed = 100f;

    private float currentSpeed;

    void Start()
    {
        currentSpeed = trackSpeed;
    }

    void Update()
    {
        // Movimiento hacia adelante y hacia atrás
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * currentSpeed * Time.deltaTime);

        // Rotación hacia la izquierda y derecha
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Si el carro entra en el terreno de césped, reducir la velocidad
        if (collision.gameObject.CompareTag("Grass"))
        {
            currentSpeed = grassSpeed;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // Si el carro sale del terreno de césped y vuelve a la pista, restablecer la velocidad
        if (collision.gameObject.CompareTag("Grass"))
        {
            currentSpeed = trackSpeed;
        }
    }
}
