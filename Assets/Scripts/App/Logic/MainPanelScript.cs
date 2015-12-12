using UnityEngine;
using System.Collections;
using com.lovelydog;

public class MainPanelScript : FacadeMonoBehaviour
{
    CanvasGroup canvas;

    void Awake()
    {
        canvas = transform.GetComponent<CanvasGroup>();
        _dispatcher.AddListener("hide_main", Hide);
        _dispatcher.AddListener("show_main", Show);
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
