using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public tk2dUIItem btnContinute;

    public tk2dTextMesh txtCauHoi;
    public tk2dTextMesh txtDapAn;
    public tk2dTextMesh txtDiemSo;
    public tk2dTextMesh txtDiemCao;

	public tk2dSprite avatar;



	public void doRandonSprite()
	{
		int chon = UnityEngine.Random.Range (0, 20);
		switch (chon) {
		case 1:
			avatar.SetSprite ("e_1");
			break;
		case 2:
			avatar.SetSprite ("e_2");
			break;
		case 3:
			avatar.SetSprite ("e_3");
			break;
		case 4:
			avatar.SetSprite ("e_4");
			break;
		case 5:
			avatar.SetSprite ("e_5");
			break;
		case 6:
			avatar.SetSprite ("e_6");
			break;
		case 7:
			avatar.SetSprite ("e_7");
			break;
		case 8:
			avatar.SetSprite ("e_8");
			break;
		case 9:
			avatar.SetSprite ("e_9");
			break;
		case 10:
			avatar.SetSprite ("e_10");
			break;
		case 11:
			avatar.SetSprite ("e_11");
			break;
		case 12:
			avatar.SetSprite ("e_12");
			break;
		case 13:
			avatar.SetSprite ("e_13");
			break;
		case 14:
			avatar.SetSprite ("e_14");
			break;
		case 15:
			avatar.SetSprite ("e_15");
			break;
		case 16:
			avatar.SetSprite ("e_16");
			break;
		case 17:
			avatar.SetSprite ("e_17");
			break;
		case 18:
			avatar.SetSprite ("e_18");
			break;
		case 19:
			avatar.SetSprite ("e_19");
			break;
		default:
			avatar.SetSprite ("e_19");
			break;
		}
	}

    public void setData(string pQue,string pDa,int pMax)
    {
        txtCauHoi.text = pQue;
        txtDapAn.text = "Đáp án:"+pDa;
        txtDiemSo.text = "Điểm số:"+GameController.instance.mScore;
        txtDiemCao.text = "Điểm cao nhất:" + pMax;
		doRandonSprite ();
    }

	public void btnContinute_OnClick()
	{
        SoundManager.Instance.PlayAudioCick();
		GameController.instance.doReset ();
		PopUpController.instance.HideGameOver ();
		PopUpController.instance.ShowMainGame ();
	}

	// Use this for initialization
	void Start () {
		btnContinute.OnClick += btnContinute_OnClick;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
