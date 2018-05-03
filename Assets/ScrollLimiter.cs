using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollLimiter : MonoBehaviour {

	public RectTransform Slider;
	public ScrollRect Scroll;
	// Use this for initialization
	void Start () {
		
		Slider = GetComponent<RectTransform> ();


	}
	
	// Update is called once per frame
	void Update () {
		if (Slider.offsetMax.y <= 0)
			Scroll.GetComponent<ScrollRect> ().movementType=ScrollRect.MovementType.Elastic;

		else if((Slider.offsetMax.y > 0)&&(Slider.offsetMax.y < (Yle.YLE.data.Count)*15+200))
			Scroll.GetComponent<ScrollRect> ().movementType=ScrollRect.MovementType.Unrestricted;

		else
			Scroll.GetComponent<ScrollRect> ().movementType=ScrollRect.MovementType.Elastic;


	}
}
