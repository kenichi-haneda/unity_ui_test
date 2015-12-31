using UnityEngine;
using System.Collections;

public class Select_Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Select_Test1(){
		Application.LoadLevel("ui_test1");
	}

	public void Select_Test2(){
		Application.LoadLevel("ui_test2");
	}

	public void Select_Test3(){
		Application.LoadLevel("ui_test3");
	}

}
