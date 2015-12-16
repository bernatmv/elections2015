using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using com.lovelydog;

public class PartyLogoScript : FacadeMonoBehaviour 
{
	Image logo;

	void Awake() {
		logo = transform.GetComponent<Image> ();
		_dispatcher.AddListener ("results_party", SetLogo);
	}

	void SetLogo(Object param) {
		logo.sprite = Properties.parties[((PayloadObject)param).intPayload].logo;
	}
}
