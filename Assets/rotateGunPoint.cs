﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateGunPoint : MonoBehaviour {

    public GameObject cam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.rotation = cam.transform.rotation;
	}
}
