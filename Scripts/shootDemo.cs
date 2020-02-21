using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootDemo : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 100;
    public int ammoPerMag = 3;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            for (int i = 0; i < ammoPerMag; i++)
            {
                Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;

                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
                //yield return new WaitForSeconds(1);
                //StartCoroutine(waitCoroutine());
            }
        }
    }
    /*IEnumerator waitCoroutine()
    {
        yield return new WaitForSeconds(1);
    }*/
}
