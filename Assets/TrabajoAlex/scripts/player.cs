using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    int puntuacion = 0;
    public Text texto;
    public float Rspeed = 8;
    public float jumpSpeed= 2;
    Rigidbody2D rb;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        // float h = Input.GetAxisRaw("Horizontal");
        //direccion = new Vector3(h, 0, 0);
        //transform.Translate(direccion * speed * Time.deltaTime, Space.World);
        float xClamped = Mathf.Clamp(transform.position.x, -8.45f, 34.9f);
        transform.position = new Vector3(xClamped, transform.position.y, transform.position.z);
        
        if (Input.GetKeyDown(KeyCode.Space)&& check.isGround)
        {

            rb.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        }
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "coins")
        {
            Destroy(collision.gameObject);
            puntuacion += 1; //sumar +1 ....
            texto.text = "Coins : " + puntuacion;   //asigno a text el valor concatenado...


        }
    }

}
