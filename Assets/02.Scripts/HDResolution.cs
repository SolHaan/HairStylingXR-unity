﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HDResolution : MonoBehaviour
{
    void Awake()
    {
        Screen.SetResolution(1280, 720, false);
    }
}
