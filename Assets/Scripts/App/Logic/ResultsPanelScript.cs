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
    }

	void Start ()
    {
        Utils.show(canvas);
        result.text = Properties.parties[0].name + " " + Properties.parties[0].ProgressiveVSConservative + " " + Properties.parties[0].LeftVSRight;
        // to remove
    }
}
