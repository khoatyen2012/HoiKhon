﻿using UnityEngine;
using System.Collections;
using System;

public class ShareRate
{

	public static string titleShare = "Hỏi Ngu - Thách Thức Sự Trong Sáng";
    public static string LinkShare = "https://play.google.com/store/apps/details?id=hoixoay.hoingu.dapxoay";
    public static string LinkShareBalo = "https://play.google.com/store/apps/developer?id=Balo+Studios";

	//public static string LinkShare = "https://itunes.apple.com/us/app/hỏi-ngu-hại-não/id1373120021";
	//public static string LinkShareBalo = "https://play.google.com/store/apps/developer?id=Balo+Studios";


    public static void Share()
    {
       #if UNITY_IPHONE

		string facebookshare = "https://www.facebook.com/sharer/sharer.php?u=" + Uri.EscapeUriString(LinkShare);
		Application.OpenURL(facebookshare);

       #endif

        //execute the below lines if being run on a Android device
     #if UNITY_ANDROID
        //Refernece of AndroidJavaClass class for intent
        AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
        //chay tren may that se het loi
        //Refernece of AndroidJavaObject class for intent
        AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
        //call setAction method of the Intent object created
        intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
        //set the type of sharing that is happening
        intentObject.Call<AndroidJavaObject>("setType", "text/plain");
        //add data to be passed to the other activity i.e., the data to be sent
        intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), titleShare);
        intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), LinkShare);
        //get the current activity
        AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");
        //start the activity by sending the intent data
        currentActivity.Call("startActivity", intentObject);
     #endif
    }

    public static void Rate()
    {
        Application.OpenURL(LinkShare);
    }

    public static void RateBalo()
    {
        Application.OpenURL(LinkShareBalo);
    }



}
