using UnityEngine;
using System.Collections;
using com.lovelydog;

public class AppLogic : FacadeMonoBehaviour 
{
    int currentQuestion = 0;

    void Awake()
    {
        _dispatcher.AddListener("start", StartQuiz);
        _dispatcher.AddListener("next_question", StartQuiz);
    }

    void StartQuiz(Object param)
    {
        _dispatcher.Dispatch("show_question");
        _dispatcher.Dispatch("hide_main");
        NextQuestion();
    }

    void NextQuestion()
    {
        currentQuestion++;
        _dispatcher.Dispatch("next_question", new PayloadObject(currentQuestion));
    }
}
