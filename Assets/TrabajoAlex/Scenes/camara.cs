using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    Vector2 distancia;

    GameObject redrunner;
    // Start is called before the first frame update

    
    void Start()
    {
       redrunner = GameObject.FindGameObjectWithTag("runner");
       distancia = transform.position - redrunner.transform.position ;
    }

    // Update is called once per frame
    void Update()
    {
        float yclamped = Mathf.Clamp(transform.position.y, -5f, 3f);
        float xClamped = Mathf.Clamp(transform.position.x, -8.45f, 27f);
        transform.position = new Vector3(xClamped, yclamped, transform.position.z);

        if (redrunner != null )
        {
            Vector3 puntoDestino = redrunner.transform.position + new Vector3(0, 0, -12);
             transform.position =  Vector3.Lerp(transform.position, puntoDestino, 3 * Time.deltaTime);
          
           float xClamp =  Mathf.Clamp(transform.position.x, -4.5f, 26.53f);
           float yClamp =  Mathf.Clamp(transform.position.y, -1.19f, 7.3f);
           
            transform.position = new Vector3(xClamp, yClamp, transform.position.z);

        }
        else
        {
            redrunner = GameObject.FindGameObjectWithTag("runner");
        }
    }
}
