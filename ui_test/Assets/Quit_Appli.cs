using UnityEngine;
using System.Collections;

public class Quit_Appli : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Androidの戻るボタンで終了する
		if (Application.platform == RuntimePlatform.Android && Input.GetKey(KeyCode.Escape)){
			Application.Quit();
		} 
	}
}
