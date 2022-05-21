﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
         transform.Rotate(0,-90,0);
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector3 (28, 2, 0);
        transform.position = plane.transform.position + offset;
    }
}
