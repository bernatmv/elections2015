using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using com.lovelydog;

public class PartyNameScript : FacadeMonoBehaviour 
{
	Text name;

	void Awake() {
		name = transform.GetComponent<Text> ();
		_dispatcher.AddListener ("results_party", SetName);
	}

	void SetName(Object param) {
		name.text = Properties.parties[((PayloadObject)param).intPayload].name;
	}
}
