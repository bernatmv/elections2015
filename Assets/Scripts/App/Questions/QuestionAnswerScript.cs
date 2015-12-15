using UnityEngine;
using System.Collections;
using com.lovelydog;

public class QuestionAnswerScript : FacadeMonoBehaviour 
{
	public int value = 0;

	CanvasGroup canvas;

	void Awake() {
		canvas = transform.GetComponent<CanvasGroup> ();
	}

	void Start() {
		reset ();
	}

	public void selectThis() {
		_dispatcher.Dispatch("answer_question", new PayloadObject(value));
	}

	public void reset() {
		if (Mathf.Abs (value) == 1) {
			Utils.hide (canvas);
		}
	}
}
