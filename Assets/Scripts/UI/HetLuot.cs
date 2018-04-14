﻿using UnityEngine;
using System.Collections;

public class HetLuot : MonoBehaviour {


	public tk2dUIItem btnContinute;

	public void btnContinute_OnClick()
	{
        SoundManager.Instance.PlayAudioCick();
		GameController.instance.currentState = GameController.State.Question;
		PopUpController.instance.HideHetLuot ();
		PopUpController.instance.ShowInGame ();
	}

	// Use this for initialization
	void Start () {
		btnContinute.OnClick += btnContinute_OnClick;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
