using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pajaro : MonoBehaviour
{
    public float pajarotiempoVivo = 0f;
    public float pajarotiempoMaximoDeVida = 5f;
    public float pajarovelocidad = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(pajarovelocidad * (Time.deltaTime), 0, 0);
        pajarotiempoVivo += Time.deltaTime;

        if (pajarotiempoVivo >= pajarotiempoMaximoDeVida)
        {
            Destroy(this.gameObject);
        }
    }
}