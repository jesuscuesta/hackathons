﻿using UnityEngine;
using System.Collections;

public class MovePlane : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
            transform.Translate(-10f * Time.deltaTime, 0f, 0f);
        
    }
}
