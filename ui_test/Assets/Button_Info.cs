using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button_Info : MonoBehaviour {
	public Text ButtonInfoText; //Text用変数
	int button_a, button_b, button_c, button_monar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int sum;
		ButtonInfoText.text = "Aを押した回数：" + button_a.ToString () + "\n";
		ButtonInfoText.text += "Bを押した回数：" + button_b.ToString () + "\n";
		ButtonInfoText.text += "Cを押した回数：" + button_c.ToString () + "\n";
		ButtonInfoText.text += "モナーを押した回数：" + button_monar.ToString () + "\n";


		sum = button_a + button_b + button_c + button_monar;
		ButtonInfoText.text += "合計：" + sum.ToString();

	}

	public void CountButtonA(){
		button_a++;
	}

	public void CountButtonB(){
		button_b++;
	}

	public void CountButtonC(){
		button_c++;
	}

	public void CountButtonMonar(){
		button_monar++;
	}

}
