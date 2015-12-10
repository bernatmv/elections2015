using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public static class Properties 
{
	// general
	public static int numQuestions = 32;
	public static float timeFadeInQuestion = 0.5f;
	public static float timeFadeOutQuestion = 0.5f;
	public static float timeToAppearAnswer = 1.0f;
	public static float timeFadeInAnswer = 0.5f;
	public static float timeToSpliceAnswer = 1.0f;
	public static float timeSpliceAnswer = 0.5f;
		// les preguntes alternen el color de fons en funció dels colors pastel (eliminar conflictius)
		// posar per config també el color de texte (blanc)
		// landing i resultats color blanc de fons i negre de lletra (no cal posar-ho a config)
		// posar a config si les preguntes son invertides o no (per sumar els punts o restar-los) i els textes 
		// posar a la config els valors de LvsR & PvsC dels diferents partits per fer el gràfic i els resultats així com el nom i el logo
	public static Color bgColor = newRGBColor(255, 255, 255);
	// methods
	public static Color newRGBColor(int red, int green, int blue, int alpha = 255) {
		return new Color(red/255f, green/255f, blue/255f, alpha/255f);
	}
}