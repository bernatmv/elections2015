using UnityEngine;
using System.Collections;
using com.lovelydog;

public class AppLogic : FacadeMonoBehaviour 
{
    int currentQuestion = -1;
	int[] answers = new int[] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
	int LvsR = 0;
	int PvsC = 0;

    void Awake()
    {
        _dispatcher.AddListener("start", StartQuiz);
		_dispatcher.AddListener("answer_question", AnswerQuestion);
    }

	void StartQuiz(Object param = default(Object))
    {
        _dispatcher.Dispatch("show_question");
        _dispatcher.Dispatch("hide_main");
        NextQuestion();
    }

    void NextQuestion()
    {
        currentQuestion++;
		if (currentQuestion < Properties.questions.Length) {
			_dispatcher.Dispatch ("set_question", new PayloadObject (currentQuestion));
		} 
		else {
			EndQuiz ();
		}
    }

	void AnswerQuestion(Object param = default(Object))
	{
		answers [currentQuestion] = ((PayloadObject)param).intPayload;
		NextQuestion ();
	}

	void EndQuiz() 
	{
		_dispatcher.Dispatch("show_results");
		_dispatcher.Dispatch("results_party", new PayloadObject(0));
		_dispatcher.Dispatch("results_party_affinity", new PayloadObject(69));
		_dispatcher.Dispatch("hide_question");
	}
}
