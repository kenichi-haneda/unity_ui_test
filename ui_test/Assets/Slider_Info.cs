using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Slider_Info : MonoBehaviour {
	public Text SliderInfoText; //Text用変数
	public Text Slider_a_Text; //Text用変数
	public Text Slider_b_Text; //Text用変数

	private float slider_a;
	private GameObject slider_a_obj;

	private float slider_b;
	private GameObject slider_b_obj;


	// Use this for initialization
	void Start () {
		slider_a_obj = GameObject.Find ("SliderA");
		slider_b_obj = GameObject.Find ("SliderB");
	}
	
	// Update is called once per frame
	void Update () {
		SliderInfoText.text = "SliderAの値：" + slider_a.ToString() + "\n";
		SliderInfoText.text += "SliderBの値：" + slider_b.ToString() + "\n";

		Slider_a_Text.text = slider_a_obj.GetComponent<Slider> ().value.ToString ("0.00") + "%";
		Slider_b_Text.text = "Lv." + slider_b_obj.GetComponent<Slider> ().value.ToString();
	}

	public void SetSliderA(float a){
		slider_a = a;
	}

	public void SetSliderB(float a){
		slider_b = a;
	}

}
