using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBola : MonoBehaviour
{
    Rigidbody rb;
    Vector3 direccion;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");    
        float v = Input.GetAxisRaw("Vertical");
        direccion = new Vector3(h, 0, v);
    }
    private void FixedUpdate()
    {
        rb.AddForce(direccion.normalized * 20, ForceMode.Force);
    }

}
