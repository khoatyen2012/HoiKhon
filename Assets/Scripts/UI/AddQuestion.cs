using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using System;

public class AddQuestion : MonoBehaviour {

    public InputField txtName;
    public InputField txtQuestion;
    public InputField txtTraLoi;
    public InputField txtGiaiThich;

    public tk2dUIItem btnGuiCauHoi;
    public tk2dUIItem btnBack;
    
	public tk2dTextMesh txtThongBao;

    string mName = "";
    string mQuestion = "";
    string mTraLoi = "";
    string mGiaiThich = "";

	DatabaseReference mDatabaseRef;


    public void setData()
    {
		txtThongBao.text = "";
        doDefault();
    }

    public void doDefault()
    {
		
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


		if(mName.Equals("") ||mQuestion.Equals("")||mTraLoi.Equals("")||mGiaiThich.Equals(""))
		{
			
			txtThongBao.text = "Vui lòng nhập đầy đủ thông tin để gửi câu hỏi !";
		
			
		}else
		{
			writeNewUser ();

		}


        doDefault();

    }

	private void writeNewUser()
	{
		try{
			
			string id = "adam" + GetUniqueIdentifier ();
		string datetime = DateTime.Now.Day + "n" + DateTime.Now.Month + "t" + DateTime.Now.Year;

			//Debug.Log(id+"--"+datetime+"--"+mQuestion);

		QuestionUD qs = new QuestionUD (id, datetime, mName, mQuestion, mTraLoi, mGiaiThich);
		string json = JsonUtility.ToJson(qs);

			mDatabaseRef.Child("questions").Child(datetime).Child(id).SetRawJsonValueAsync(json);

			txtThongBao.text = "Gửi câu hỏi thành công. Chân thành cảm ơn !";
		}catch (Exception ex)
		{
			txtThongBao.text = "Kiểm tra lại kết nối mạng !";
		}
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

		// Set this before calling into the realtime database.
		FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://first-skein-774.firebaseio.com/");
		mDatabaseRef = FirebaseDatabase.DefaultInstance.RootReference;

	}

	public static string GetUniqueIdentifier()
	{
		System.Guid uid = System.Guid.NewGuid();
		return uid.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
