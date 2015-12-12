using UnityEngine;
using System.Collections;
using com.lovelydog;

public class StartButtonScript : FacadeMonoBehaviour
{
    public void StartQuiz()
    {
        _dispatcher.Dispatch("start");
    }
}
