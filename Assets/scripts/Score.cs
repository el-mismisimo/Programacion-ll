using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float puntajeinicial;
    public float sumapuntaje;
    // Start is called before the first frame update
    void Start()
    {
        puntajeinicial = 0f;
        sumapuntaje = 30f;

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "puntaje: " + (int)puntajeinicial;
        puntajeinicial += sumapuntaje * Time.deltaTime;

    }
}
