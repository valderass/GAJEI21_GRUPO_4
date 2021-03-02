using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientocoche : MonoBehaviour
{

    public Rigidbody rb;
    public Transform car;
    public float speed = 17;

    Vector3 forward = new Vector3(1, 0, 0);
    Vector3 backward = new Vector3(-1, 0, 0);

    Vector3 rotationRight = new Vector3(0, 0, -30);
    Vector3 rotationLeft = new Vector3(0, 0, 30);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.MovePosition(car.position + forward * speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.MovePosition(car.position + backward * speed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            Quaternion deltaRotationRight = Quaternion.Euler(rotationRight * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotationRight);
        }

        if (Input.GetKey("a"))
        {
            Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotationLeft);
        }

    }
}
