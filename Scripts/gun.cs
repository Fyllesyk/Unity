using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
 
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            transform.Translate(0f, 0.5f, 0f);
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            transform.Translate(0f, -0.5f, 0f);
        }
    }
}
