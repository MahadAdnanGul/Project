﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dont_destroy_char : MonoBehaviour
{
    static Dont_destroy_char instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
