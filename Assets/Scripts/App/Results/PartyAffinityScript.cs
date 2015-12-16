using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using com.lovelydog;

public class PartyAffinityScript : FacadeMonoBehaviour 
{
	Text affinity;

	void Awake() {
		affinity = transform.GetComponent<Text> ();
		_dispatcher.AddListener ("results_party_affinity", SetAffinity);
	}

	void SetAffinity(Object param) {
		affinity.text = ((PayloadObject)param).intPayload + "%";
	}
}
