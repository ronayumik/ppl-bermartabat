﻿using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {

	// Use this for initialization
	public float lifetime;
	void Start () {
		Destroy (gameObject , lifetime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
