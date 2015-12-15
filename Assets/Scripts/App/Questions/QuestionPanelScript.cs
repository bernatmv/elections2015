using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using com.lovelydog;

public class QuestionPanelScript : FacadeMonoBehaviour
{
    CanvasGroup canvas;
	Image bg;

    void Awake()
    {
        canvas = transform.GetComponent<CanvasGroup>();
		bg = transform.GetComponent<Image> ();
        _dispatcher.AddListener("hide_question", Hide);
        _dispatcher.AddListener("show_question", Show);
		_dispatcher.AddListener("set_question", SetQuestion);
	}

	void SetQuestion(Object param = default(Object))
	{
		bg.color = Properties.questionColors[((PayloadObject)param).intPayload % Properties.questionColors.Length];
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
