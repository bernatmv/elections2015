using UnityEngine;
using System.Collections;
using com.lovelydog;

public class QuestionPanelScript : FacadeMonoBehaviour
{
    CanvasGroup canvas;

    void Awake()
    {
        canvas = transform.GetComponent<CanvasGroup>();
        _dispatcher.AddListener("hide_question", Hide);
        _dispatcher.AddListener("show_question", Show);
    }

    void Hide(Object param = default(Object))
    {
        Utils.hide(canvas);
    }

    void Show(Object param = default(Object))
    {
        Utils.show(canvas);
    }
}
