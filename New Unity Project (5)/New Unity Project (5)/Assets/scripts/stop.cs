﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void onCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
 