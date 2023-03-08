using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void botones()
    {
        SceneManager.LoadScene("ESCENARIO1");
    }

    public void botonsalir()
    {
        Application.Quit();

    }



}
