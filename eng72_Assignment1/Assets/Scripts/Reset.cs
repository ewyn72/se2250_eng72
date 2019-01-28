﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            gameObject.transform.position = originalPos;
        }
    }
        
    
}
