using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using com.lovelydog;

public class ResultsPanelScript : FacadeMonoBehaviour
{
    CanvasGroup canvas;
    Text result;

    void Awake()
    {
        canvas = transform.GetComponent<CanvasGroup>();
        result = transform.GetComponentInChildren<Text>();
        _dispatcher.AddListener("hide_results", Hide);
        _dispatcher.AddListener("show_results", Show);
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
