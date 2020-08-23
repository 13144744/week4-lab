using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    Vector3 pos1;
    Vector3 pos2;
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;
    // Start is called before the first frame update
    void Start()
    {
        pos1 = new Vector3(2f, 0f, 0f);
        pos2 = new Vector3(-2f, 0f, 0f);
        _ = (GameObject)Instantiate(redObj, pos1, transform.rotation);
        _ = (GameObject)Instantiate(blueObj, pos2, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
