using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello from Start");
    }

    void Update()
    {
        Debug.Log("Hello from Update");
        this.transform.Rotate(new Vector3(0f, 2f, 0f), 25f * Time.deltaTime );
    }
}
