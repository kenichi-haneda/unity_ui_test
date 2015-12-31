using UnityEngine;
using System.Collections;

public class Create_Cube : MonoBehaviour {
	public GameObject cube;
	float size = 2.0f;
	float level = 1.5f;

	// Use this for initialization
	void Start () {
		StartCoroutine("Create");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Create(){
		while (true) {
			Vector3 pos = new Vector3 (Random.Range (-8.0f, 8.0f), 16.0f, 10.0f);
			Instantiate (cube, pos, Quaternion.identity);
			yield return new WaitForSeconds (level);
		}
	}

	public void SetCubeSize(float a){
		size = 2.0f + (2.0f * a/100);
	}

	public float GetCubeSize(){
		return size;
	}

	public void SetCreateLevel(float a){
		level =1.5f - a*0.1f;
	}
	
}
