using UnityEngine;
using System.Collections;

public class DataManager  {

    private static string TAG_HIGHT = "ssf";

    //get lai gia tri second cua bai 3 khi con thong thai.

    public static int GetHightScore()
    {
        if (PlayerPrefs.HasKey(TAG_HIGHT))
        {
            return PlayerPrefs.GetInt(TAG_HIGHT);
        }
        else
        {
            return 0;
        }
    }

    //Luu lai gia tri second cua bai 3 khi con thong thai.
    public static void SaveHightScore(int newHightScore)
    {
        PlayerPrefs.SetInt(TAG_HIGHT, newHightScore);
    }
}
