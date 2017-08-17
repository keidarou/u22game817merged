﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Button))]

public class MoveScene : UIBehaviour {


	public int [,] mapData=new int[50,50];


	protected override void Start () {

		base.Start ();

		//GetComponent<Button> ().onClick.AddListener (OnClick);
	}


	void OnClick(){

		SceneManager.LoadScene ("MainGame");

	}


	// Update is called once per frame
	void Update () {

	}
}
