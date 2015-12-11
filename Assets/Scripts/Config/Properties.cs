using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Linq;

public static class Properties 
{
    public class PoliticalParty
    {
        public string name;
        public Sprite logo;
        public int LeftVSRight = 0;
        public int ProgressiveVSConservative = 0;
        public int[] answers;

        public PoliticalParty(string newName, string newLogo, int[] newAnswers)
        {
            name = newName;
            logo = Resources.Load<Sprite>("logos/" + newLogo);
            answers = newAnswers;
            LeftVSRight = answers.Take(16).Sum();
            ProgressiveVSConservative = answers.Skip(16).Take(16).Sum();
        }
    }
    public class Question
    {
        public int mode = 1; // if it's inverted
        public string question = "";

        public Question(string newQuestion, int newMode = 1)
        {
            question = newQuestion;
            mode = newMode;
        }
    }
    // general
    public static int numQuestions = 32;
	public static float timeFadeInQuestion = 0.5f;
	public static float timeFadeOutQuestion = 0.5f;
	public static float timeToAppearAnswer = 1.0f;
	public static float timeFadeInAnswer = 0.5f;
	public static float timeToSpliceAnswer = 1.0f;
	public static float timeSpliceAnswer = 0.5f;
    // political parties
    public static PoliticalParty[] parties = new PoliticalParty[]
    {
        new PoliticalParty("Izquierda Unida", "iu", new int[] {
            2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2, // LvsR
            2,1,2,2,2,2,1,2,2,2,2,2,2,1,0,2  // PvsC
        })
    };
    // questions
    public static Question[] questions = new Question[]
    {
        new Question("Más pasta escuela pública, menos concertada", 1)
    };
    // colors
	public static Color bgColor = newRGBColor(255, 255, 255);
    public static Color[] questionColors = {
		// les preguntes alternen el color de fons en funció dels colors pastel (eliminar conflictius)
        newRGBColor(0,0,0)
    };
	// methods
	public static Color newRGBColor(int red, int green, int blue, int alpha = 255) {
		return new Color(red/255f, green/255f, blue/255f, alpha/255f);
	}
}