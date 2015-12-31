using UnityEngine;
using System.Collections;

public class Cube_Action1 : MonoBehaviour {
	private GameObject cameraObj;

	// Use this for initialization
	void Start () {
		float size;
		cameraObj = GameObject.Find ("Main Camera");
		size = cameraObj.GetComponent<Create_Cube> ().GetCubeSize();
		transform.localScale = new Vector3 (size, size, size);
		Destroy (gameObject, 20.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
