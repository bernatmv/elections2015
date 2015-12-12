using UnityEngine;
using System.Collections;
using com.lovelydog;

public class AppLogic : FacadeMonoBehaviour 
{
    void Awake()
    {
        _dispatcher.AddListener("start", StartQuiz);
    }

    void StartQuiz(Object param)
    {
        _dispatcher.Dispatch("show_question");
        _dispatcher.Dispatch("hide_main");
    }
}
