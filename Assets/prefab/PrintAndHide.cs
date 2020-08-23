using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA;

public class PrintAndHide : MonoBehaviour
{
    int i = 0;
    int b = 0;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        b = Random.Range(200, 250);
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
        if (gameObject.tag == "Blue" && i == b){

            rend.enabled = false;
        }
        i = i + 1;
        Debug.Log(gameObject.name + ":" + i);
    }
}
