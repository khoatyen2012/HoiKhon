using UnityEngine;
using System.Collections;

public class PopUpController : MonoBehaviour {

    #region Singleton
    private static PopUpController _instance;

    public static PopUpController instance
    {
        get
        {
            if (_instance == null)
                _instance = GameObject.FindObjectOfType<PopUpController>();
            return _instance;
        }
    }
    #endregion

    public float showY;
    public float hideY;

    public MainGame maingame;


    public void ShowMainGame()
    {
        maingame.transform.position = new Vector3(maingame.transform.position.x, showY, maingame.transform.position.z);
    }

    public void HideMainGame()
    {
        maingame.transform.position = new Vector3(maingame.transform.position.x, hideY, maingame.transform.position.z);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
