using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public tk2dUIItem btnContinute;

	public void btnContinute_OnClick()
	{
		GameController.instance.doReset ();
		PopUpController.instance.HideGameOver ();
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
