using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using com.lovelydog;

public class QuestionTextScript : FacadeMonoBehaviour 
{
	Text question;

	void Awake() {
		question = transform.GetComponent<Text> ();
	}

	void Start() {
		question.text = "boooo";
	}
}
