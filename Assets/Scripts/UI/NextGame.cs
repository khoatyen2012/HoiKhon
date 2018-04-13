using UnityEngine;
using System.Collections;

public class NextGame : MonoBehaviour {


	public tk2dUIItem btnHoiTiep;

	public tk2dTextMesh txtGiaiThich;

	public void setData(string pGT)
	{
		txtGiaiThich.text = "" + pGT;
	}



	public void btnHoiTiep_OnClick()
	{
        SoundManager.Instance.PlayAudioCick();
		PopUpController.instance.HideNextGame ();
		PopUpController.instance.ShowInGame ();
	}

	// Use this for initialization
	void Start () {
		btnHoiTiep.OnClick += btnHoiTiep_OnClick;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
