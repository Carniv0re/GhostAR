﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {

		text.text = 0.ToString();
		
	}
	
	// Update is called once per frame
	void Update () {

		text.text = Score.Counter.ToString ();

	}
}
