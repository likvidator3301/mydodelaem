﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLowerVolume : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().volume = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
