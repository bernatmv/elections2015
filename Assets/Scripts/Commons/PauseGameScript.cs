using UnityEngine;
using System.Collections;
using com.lovelydog;

public class PauseGameScript : FacadeMonoBehaviour 
{
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			if (Time.timeScale > 0) Time.timeScale = 0;
			else Time.timeScale = 1;
		}
	}
}
