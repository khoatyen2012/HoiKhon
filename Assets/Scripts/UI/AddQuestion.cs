using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;

public class AddQuestion : MonoBehaviour {

    public InputField txtName;
    public InputField txtQuestion;
    public InputField txtTraLoi;
    public InputField txtGiaiThich;

    public tk2dUIItem btnGuiCauHoi;
    public tk2dUIItem btnBack;
    public GameObject message;

    string mName = "";
    string mQuestion = "";
    string mTraLoi = "";
    string mGiaiThich = "";


    public void setData()
    {
        doDefault();
    }

    public void doDefault()
    {
        message.SetActive(false);
        txtName.text = "";
        txtQuestion.text = "";
        txtTraLoi.text = "";
        txtGiaiThich.text = "";
      
    }

    public void btnGuiCauHoi_OnClick()
    {
        mName = txtName.text;
        mQuestion = txtQuestion.text;
        mTraLoi = txtTraLoi.text;
        mGiaiThich = txtGiaiThich.text;
        


        doDefault();

    }
    public void btnBack_OnClick()
    {
        doDefault();
        PopUpController.instance.HideAddQuesstion();
        PopUpController.instance.ShowMainGame();
    }


	// Use this for initialization
	void Start () {

        btnBack.OnClick += btnBack_OnClick;
        btnGuiCauHoi.OnClick += btnGuiCauHoi_OnClick;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
