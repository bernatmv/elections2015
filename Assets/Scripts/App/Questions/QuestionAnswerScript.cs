using UnityEngine;
using System.Collections;
using com.lovelydog;

public class QuestionAnswerScript : FacadeMonoBehaviour 
{
	public float value = 0f;

	CanvasGroup canvas;

	void Awake() {
		canvas = transform.GetComponent<CanvasGroup> ();
	}

	void Start() {
		reset ();
	}

	public void selectThis() {
		
	}

	public void reset() {
		if (Mathf.Abs (value) == 1) {
			Utils.hide (canvas);
		}
	}
}
