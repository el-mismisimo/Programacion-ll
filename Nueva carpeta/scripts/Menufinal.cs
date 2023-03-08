using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menufinal : MonoBehaviour
{
    void Start()
    {

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void AGAIN()
    {
        SceneManager.LoadScene("ESCENARIO1");
    }

    public void MENU()
    {
        SceneManager.LoadScene("Main menu");
    }
}