﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedOutFOW = 60f;
    [SerializeField] float zoomedInFOW = 20f;

    bool zoomedInToggle = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsCamera.fieldOfView = zoomedInFOW;
            }
            else if (zoomedInToggle == true)
            {
                zoomedInToggle = false;
                fpsCamera.fieldOfView = zoomedOutFOW;
            }
        }
    }
}
