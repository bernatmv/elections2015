using UnityEngine;
using System.Collections;
using com.lovelydog;

public class MainPanelScript : FacadeMonoBehaviour
{
    CanvasGroup canvas;

    void Awake()
    {
        canvas = transform.GetComponent<CanvasGroup>();
    }

    void Start()
    {
    }
}
