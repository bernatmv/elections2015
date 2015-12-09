using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public static class Properties {
	// general
	public static Color bgColor = newRGBColor(255, 255, 255);
	// methods
	public static Color newRGBColor(int red, int green, int blue, int alpha = 255) {
		return new Color(red/255f, green/255f, blue/255f, alpha/255f);
	}
}