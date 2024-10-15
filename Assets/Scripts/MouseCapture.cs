using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCapture : MonoBehaviour
{
    public GameObject mouseEntity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);
        }
    }
}
