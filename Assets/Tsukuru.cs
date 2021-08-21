using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tsukuru : MonoBehaviour
{
    public GameObject Obj;
    float zikan;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.fixedTime - zikan > 3f)
        {
            Instantiate(Obj, new Vector3(0f, 0f, 0f), Quaternion.identity);
            zikan = Time.fixedTime;
        }
    }
}