﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Input.GetAxis("Horizontal")*10f*Time.deltaTime,0f,0f);

      

    }


   
}
