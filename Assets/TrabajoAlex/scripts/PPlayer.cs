using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPlayer : MonoBehaviour
{

    int h, v;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (v == 0)
        {
            h = (int)Input.GetAxisRaw("Horizontal");
        }
        if (h == 0)
        {
            v = (int)Input.GetAxisRaw("Vertical");
        }
        anim.SetInteger("h", h);
        anim.SetInteger("v", v);
        transform.Translate(new Vector3(h, v, 0).normalized * 5 * Time.deltaTime);
    }
}
