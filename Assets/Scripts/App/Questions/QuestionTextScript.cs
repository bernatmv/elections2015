using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using com.lovelydog;

public class QuestionTextScript : FacadeMonoBehaviour 
{
	Text question;

	void Awake() 
	{
		question = transform.GetComponent<Text> ();
		_dispatcher.AddListener("set_question", SetQuestion);
	}

	void SetQuestion(Object param = default(Object))
	{
		question.text = Properties.questions [((PayloadObject)param).intPayload].question;
	}
}
