using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour

    
{
    public Text scoretext;
    public float scorenumber;
    public float scoremas;

    // Start is called before the first frame update
    void Start()
    {
        scorenumber = 0f;
        scoremas = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Score: " + (int)scorenumber;
        scorenumber += scoremas * Time.deltaTime;
    }
}
