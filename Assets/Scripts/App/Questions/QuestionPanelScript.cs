using UnityEngine;
using System.Collections;
using com.lovelydog;

public class QuestionPanelScript : FacadeMonoBehaviour
{
    CanvasGroup canvas;

    void Awake()
    {
        canvas = transform.GetComponent<CanvasGroup>();
    }

	void Start ()
    {
        Utils.hide(canvas);
	}
}
