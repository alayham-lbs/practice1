using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderWithTextController : MonoBehaviour {

    Text label;
    Slider slider;
    string initialLabel = "";

	// Use this for initialization
	void Start () {
        label = transform.Find("Text").gameObject.GetComponent<Text>();
        slider = transform.Find("Slider").gameObject.GetComponent<Slider>();
        initialLabel = label.text;
	}
	
    public void ChangeText()
    {
        label.text = initialLabel + " " + slider.value.ToString();
    }

	// Update is called once per frame
	void Update () {
		
	}
}
