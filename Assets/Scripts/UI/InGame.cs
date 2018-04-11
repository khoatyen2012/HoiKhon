using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InGame : MonoBehaviour {



	public tk2dTextMesh txtQuestion;
	public tk2dTextMesh txtDa;
	public tk2dTextMesh txtDb;
	public tk2dTextMesh txtDc;
	public tk2dTextMesh txtDd;
	public tk2dTextMesh txtNickGame;
	public tk2dTextMesh txtLuotNgu;
	public tk2dTextMesh txtScore;

	public tk2dUIItem btnA;
	public tk2dUIItem btnB;
	public tk2dUIItem btnC;
	public tk2dUIItem btnD;
	public tk2dUIItem btnAvatar;
	public GameObject mesage;

	 Question quTMG;
	public string checkque;

	string selectcase="";

	List<Question> lst=new List<Question>();


	public void btnA_OnClick()
	{
		if (GameController.instance.currentState == GameController.State.Question) {
			selectcase = "a";
			doXuLy ();
		}
	}

	public void btnB_OnClick()
	{
		if (GameController.instance.currentState == GameController.State.Question) {
			selectcase = "b";
			doXuLy ();
		}
	}

	public void btnC_OnClick()
	{
		if (GameController.instance.currentState == GameController.State.Question) {
			selectcase = "c";
			doXuLy ();
		}
	}

	public void btnD_OnClick()
	{
		if (GameController.instance.currentState == GameController.State.Question) {
			selectcase = "d";
			doXuLy ();
		}
	}


	void doXuLy()
	{

		if (selectcase.Equals (quTMG.Truecase)) {
			Debug.Log ("Dung roi");
			GameController.instance.currentState = GameController.State.ReplyTrue;
		} else {
			Debug.Log ("Sai roi");
			GameController.instance.currentState = GameController.State.ReplyFalse;
			mesage.SetActive (true);
			StartCoroutine(WaitTimeSai(1.5f));
		}
	}

	IEnumerator WaitTimeSai(float time)
	{
		//do something...............
		yield return new WaitForSeconds(time);
		mesage.SetActive (false);
	}

	public void btnAvatar_OnClick()
	{
	}

	public void setData()
	{
		GameController.instance.currentState = GameController.State.Question;
		if (lst.Count <= 0) {
			lst = GameController.instance.lst;
		}

		doSubGet ();
	}

	public void doSubGet()
	{
		if (lst.Count > 0) {
			int chon = UnityEngine.Random.Range(0, lst.Count);
			quTMG = lst [chon];
			txtQuestion.text = quTMG.Question2;
			txtDa.text =quTMG.Da;
			txtDb.text = quTMG.Db;
			txtDc.text = quTMG.Dc;
			txtDd.text = quTMG.Dd;
			txtNickGame.text ="Nick Name:"+ quTMG.Nickname;
			checkque = quTMG.Truecase;


		}
	}


	// Use this for initialization
	void Start () {
	
		btnA.OnClick += btnA_OnClick;
		btnB.OnClick += btnB_OnClick;
		btnC.OnClick += btnC_OnClick;
		btnD.OnClick += btnD_OnClick;
		btnAvatar.OnClick += btnAvatar_OnClick;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
