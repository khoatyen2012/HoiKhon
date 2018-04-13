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
    public string checkA;
    public string checkB;
    public string checkC;
    public string checkD;


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
			
			GameController.instance.mScore++;
			txtScore.text = "" + GameController.instance.mScore;
			GameController.instance.currentState = GameController.State.ReplyTrue;
            StartCoroutine(WaitTimeDung(1f));
		} else {
			
			GameController.instance.currentState = GameController.State.ReplyFalse;
			mesage.SetActive (true);
			GameController.instance.mNgu--;
			txtLuotNgu.text = "Lượt Ngu:" + GameController.instance.mNgu;
            switch (selectcase)
            {
                case "a":
                    if (quTMG.Gta.Trim().Equals(""))
                    {
					if (GameController.instance.mScore % 3 == 0)
                        {
                            mesage.transform.GetChild(0).GetComponent<tk2dTextMesh>().text = "Thím ngu vkl :))";
                        }
					else if (GameController.instance.mScore % 2 == 0)
                        {
                            mesage.transform.GetChild(0).GetComponent<tk2dTextMesh>().text = "Thím ngu vđ @@";
                        }
                        else
                        {
                            mesage.transform.GetChild(0).GetComponent<tk2dTextMesh>().text = "Óc chó có thật :))";
                        }
                    }
                    else
                    {
                        mesage.transform.GetChild(0).GetComponent<tk2dTextMesh>().text = quTMG.Gta;
                    }
                    break;
                case "b":
                    if (quTMG.Gtb.Trim().Equals(""))
                    {
					if (GameController.instance.mScore % 2 == 0)
                        {
                            mesage.transform.GetChild(0).GetComponent<tk2dTextMesh>().text = "Thím ngu vkl :))";
                        }
					else if (GameController.instance.mScore % 3 == 0)
                        {
                            mesage.transform.GetChild(0).GetComponent<tk2dTextMesh>().text = "Thím ngu vđ @@";
                        }
                        else
                        {
                            mesage.transform.GetChild(0).GetComponent<tk2dTextMesh>().text = "Óc chó có thật :))";
                        }
                    }
                    else
                    {
                        mesage.transform.GetChild(0).GetComponent<tk2dTextMesh>().text = quTMG.Gtb;
                    }
                    break;
                case "c":
                    if (quTMG.Gtc.Trim().Equals(""))
                    {
					if (GameController.instance.mScore % 4 == 0)
                        {
                            mesage.transform.GetChild(0).GetComponent<tk2dTextMesh>().text = "Thím ngu vkl :))";
                        }
					else if (GameController.instance.mScore % 3 == 0)
                        {
                            mesage.transform.GetChild(0).GetComponent<tk2dTextMesh>().text = "Thím ngu vđ @@";
                        }
                        else
                        {
                            mesage.transform.GetChild(0).GetComponent<tk2dTextMesh>().text = "Óc chó có thật :))";
                        }
                    }
                    else
                    {
                        mesage.transform.GetChild(0).GetComponent<tk2dTextMesh>().text = quTMG.Gtc;
                    }
                    break;

                default:
                    if (quTMG.Gtd.Trim().Equals(""))
                    {
					if (GameController.instance.mScore % 5 == 0)
                        {
                            mesage.transform.GetChild(0).GetComponent<tk2dTextMesh>().text = "Thím ngu vkl :))";
                        }
					else if (GameController.instance.mScore % 3 == 0)
                        {
                            mesage.transform.GetChild(0).GetComponent<tk2dTextMesh>().text = "Thím ngu vđ @@";
                        }
                        else
                        {
                            mesage.transform.GetChild(0).GetComponent<tk2dTextMesh>().text = "Óc chó có thật :))";
                        }
                    }
                    else
                    {
                        mesage.transform.GetChild(0).GetComponent<tk2dTextMesh>().text = quTMG.Gtd;
                    }
                    break;
            }
			StartCoroutine(WaitTimeSai(2f));
		}
	}

	IEnumerator WaitTimeSai(float time)
	{
		//do something...............
		yield return new WaitForSeconds(time);
		mesage.SetActive (false);
		if (GameController.instance.mNgu <= 0) {
			GameController.instance.currentState = GameController.State.GameOver;
			PopUpController.instance.HideInGame ();
            
            switch(quTMG.Truecase)
            {
                case "a":
                    PopUpController.instance.ShowGameOver (quTMG.Question2,quTMG.Da,12);
                    break;
                case "b":
                    PopUpController.instance.ShowGameOver(quTMG.Question2, quTMG.Db, 12);
                    break;
                case "c":
                    PopUpController.instance.ShowGameOver(quTMG.Question2, quTMG.Dc, 12);
                    break;
                default:
                    PopUpController.instance.ShowGameOver(quTMG.Question2, quTMG.Dd, 12);
                    break;
            }
			

		} else {
			GameController.instance.currentState = GameController.State.Question;
		}

	}

    IEnumerator WaitTimeDung(float time)
    {
        //do something...............
        yield return new WaitForSeconds(time);
        GameController.instance.currentState = GameController.State.Next;
        PopUpController.instance.HideInGame();
		switch(quTMG.Truecase)
		{
		case "a":
			PopUpController.instance.ShowNextGame(quTMG.Gta);
			break;
		case "b":
			PopUpController.instance.ShowNextGame(quTMG.Gtb);
			break;
		case "c":
			PopUpController.instance.ShowNextGame(quTMG.Gtc);
			break;
		default:
			PopUpController.instance.ShowNextGame(quTMG.Gtd);
			break;
		}
        
    
    }

	public void btnAvatar_OnClick()
	{
		if (GameController.instance.currentState == GameController.State.Question) {

			GameController.instance.mNext--;
			if (GameController.instance.mNext == 0) {
				GameController.instance.currentState = GameController.State.Next;
				PopUpController.instance.HideInGame ();
				PopUpController.instance.ShowNextGame("Em xin thua,thật là dã man mà, đành phải cho bác qua câu này vậy. A hi hi đồ ckó");

			} else if (GameController.instance.mNext < 0 && GameController.instance.mNext%3==0) {

				GameController.instance.currentState = GameController.State.HetLuot;
				PopUpController.instance.ShowHetLuot ();
				PopUpController.instance.HideInGame ();
			}
		}
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

            checkA = quTMG.Gta;
            checkB = quTMG.Gtb;
            checkC = quTMG.Gtc;
            checkD = quTMG.Gtd;

		}

		txtLuotNgu.text = "Lượt Ngu:" + GameController.instance.mNgu;
		txtScore.text = "" + GameController.instance.mScore;
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
