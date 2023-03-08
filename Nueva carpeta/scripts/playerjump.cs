using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerjump : MonoBehaviour
{
    public int fuerzaDeSalto = 5;
    public bool estaSaltando;

    void Start()
    {
        estaSaltando = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && estaSaltando == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, fuerzaDeSalto, 0);
            estaSaltando = true;
        }

        if (Input.GetKeyDown(KeyCode.S) && estaSaltando == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            estaSaltando = false;
        }

        if (collision.gameObject.tag == "rock")
        {
            
            SceneManager.LoadScene("MUERTE");
        }
    }
}