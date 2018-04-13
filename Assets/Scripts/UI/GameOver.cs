using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public tk2dUIItem btnContinute;

    public tk2dTextMesh txtCauHoi;
    public tk2dTextMesh txtDapAn;
    public tk2dTextMesh txtDiemSo;
    public tk2dTextMesh txtDiemCao;

    public void setData(string pQue,string pDa,int pMax)
    {
        txtCauHoi.text = pQue;
        txtDapAn.text = "Đáp án:"+pDa;
        txtDiemSo.text = "Điểm số:"+GameController.instance.mScore;
        txtDiemCao.text = "Điểm cao nhất:" + pMax;
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
