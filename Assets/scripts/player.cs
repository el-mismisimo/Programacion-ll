using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public int fuerzaDeSalto = 10;
    public bool estaSaltando;

    // Start is called before the first frame update
    void Start()
    {
        estaSaltando = false;
    }

    // Update is called once per frame
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
        if (collision.gameObject.tag == "Piso")
        {
            estaSaltando = false;
        }

        if (collision.gameObject.tag == "Obstaculo")
        {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
