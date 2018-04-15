using UnityEngine;
using System.Collections;

public class MainGame : MonoBehaviour {


	float mRap=1f;
	public tk2dSprite avatar;
    public tk2dUIItem btnPlay;
    public tk2dUIItem btnShare;
    public tk2dUIItem btnRate;


    public void btnShare_OnClick()
    {
        ShareRate.Share();
    }

    public void btnRate_OnClick()
    {
        ShareRate.Rate();
    }

	public void setData()
	{
		GameController.instance.currentState = GameController.State.Start;
	}


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

    public void btnPlay_OnClick()
    {
        SoundManager.Instance.PlayAudioCick();
        PopUpController.instance.HideMainGame();
        PopUpController.instance.ShowInGame();
    }

	// Use this for initialization
	void Start () {
        btnPlay.OnClick += btnPlay_OnClick;
        btnRate.OnClick += btnRate_OnClick;
        btnShare.OnClick += btnShare_OnClick;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (mRap <= 0) {
			mRap = 1f;
			doRandonSprite ();
		} else {
			mRap = mRap - 0.04f;
		}
	}
}
