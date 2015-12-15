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
        public int mode = 1; 
		public int inverted = 1; // if it's inverted
        public string question = "";

		public Question(string newQuestion, int newMode = 1, int newInverted = 1)
        {
            question = newQuestion;
            mode = newMode;
			inverted = newInverted;
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
		// name, logo, answers
		new PoliticalParty("Izquierda Unida", "iu", new int[] {
			2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2, // LvsR
			2,1,2,2,2,2,1,2,2,2,2,2,2,1,0,2  // PvsC
		}),
		new PoliticalParty("Compromís", "compromis", new int[] {
			2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,
			2,2,2,2,2,2,2,2,2,1,2,2,1,2,1,2
		}),
		new PoliticalParty("Més", "mes", new int[] {
			1,2,2,0,2,2,2,2,2,1,2,2,2,-2,2,2,
			2,2,2,1,1,2,2,2,2,1,1,1,2,2,1,2
		}),
		new PoliticalParty("Podemos", "podemos", new int[] {
			1,2,2,2,2,2,1,2,2,2,2,2,2,2,2,2,
			0,1,2,2,1,2,2,1,2,2,2,1,0,0,0,2
		}),
		new PoliticalParty("Nós", "nos", new int[] {
			2,2,2,1,2,1,2,1,2,1,1,1,1,2,2,1,
			2,2,1,2,1,1,1,0,1,1,1,2,2,2,2,2
		}),
		new PoliticalParty("Bildu", "bildu", new int[] {
			0,2,-1,1,2,2,2,1,2,2,2,2,2,-2,1,2,
			2,2,2,2,0,2,2,2,1,-1,1,2,0,0,0,1
		}),
		new PoliticalParty("ERC", "erc", new int[] {
			0,-1,2,-1,2,1,1,2,2,1,2,2,1,-2,1,1,
			2,2,1,2,2,1,2,2,2,2,2,1,2,2,1,1
		}),
		new PoliticalParty("Geroa Bai", "geroabai", new int[] {
			1,1,1,1,1,2,1,1,2,2,1,1,1,1,0,1,
			2,2,1,2,1,2,2,1,1,0,1,1,0,-1,1,0
		}),
		new PoliticalParty("PSOE", "psoe", new int[] {
			1,2,2,0,2,2,1,1,2,-1,1,1,1,-1,1,2,
			-2,-2,2,1,2,1,2,0,2,2,-1,1,0,1,0,-1
		}),
		new PoliticalParty("UPyD", "upyd", new int[] {
			2,2,2,1,2,2,1,1,1,0,0,2,1,-1,1,2,
			0,-2,-2,2,2,2,1,-1,2,0,2,-1,-1,-2,1,2
		}),
		new PoliticalParty("CC", "cc", new int[] {
			0,2,1,0,1,1,0,1,1,2,0,1,0,-2,2,2,
			0,0,0,1,2,0,0,0,0,0,0,0,0,1,2,0
		}),
		new PoliticalParty("PNV", "pnv", new int[] {
			0,1,2,1,2,1,1,0,1,-1,2,2,0,0,-1,2,
			2,2,-2,1,0,1,2,2,-1,-1,-1,-1,-1,2,1,-1
		}),
		new PoliticalParty("Ciudadanos", "ciudadanos", new int[] {
			0,0,-1,1,-1,0,0,-2,1,1,-1,0,-2,0,1,-2,
			-1,-2,-2,1,2,2,2,-2,0,2,2,0,-2,0,1,2
		}),
		new PoliticalParty("Democracia i llibertat", "democraciaillibertat", new int[] {
			-1,-2,0,-2,2,-1,1,-1,-1,-1,-2,-2,1,1,1,0,
			0,2,1,1,2,1,2,1,0,-1,-1,0,1,2,1,-1
		}),
		new PoliticalParty("Unió", "unio", new int[] {
			-2,-2,1,-2,2,-1,-1,-1,0,-1,0,-2,0,-2,-1,1,
			0,1,-2,-1,2,0,-1,-2,-2,0,-1,0,0,1,-1,0
		}),
		new PoliticalParty("UPN", "upn", new int[] {
			-2,0,-1,1,-1,0,-1,0,0,-2,0,-1,0,-2,-1,0,
			-2,-2,-2,-1,2,-2,-2,-2,-2,-1,-1,-1,-2,-1,-1,0
		}),
		new PoliticalParty("PP", "pp", new int[] {
			-1,0,-1,-1,-1,-1,-1,-2,-1,-2,-2,-1,-2,-2,-2,-2,
			-2,-2,-2,-1,2,-2,-2,-2,-2,-1,-1,-1,-2,-1,-2,-2
		}),
		new PoliticalParty("PACMA", "pacma", new int[] {
			2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
			0,0,0,0,0,0,0,0,0,0,0,2,2,0,0,0
		})
    };
    // questions
    public static Question[] questions = new Question[]
    {
		// question, mode (LvsR = 1, PvsC = 2), inverted (inverted question 1/-1)
        new Question("Más pasta escuela pública, menos concertada", 1, 1),
		new Question("Sin copago sanitario", 1, 1),
		new Question("Dación en pago", 1, 1),
		new Question("Políticos cobrar menos", 1, 1),
		new Question("Sanidad para inmigrantes sin papeles", 1, 1),
		new Question("No reducir gasto social para crecer", 1, 1),
		new Question("Más impuestos para más servicios", 1, 1),
		new Question("Estado interviene en la economia", 1, 1),
		new Question("Redistribución de la riqueza", 1, 1),
		new Question("Austeridad impide crecer", 1, 1),
		new Question("Impedir privatizaciones", 1, 1),
		new Question("Blindar el despido", 1, 1),
		new Question("Sindicatos correctos", 1, 1),
		new Question("Bajar edad de jubilación", 1, 1),
		new Question("Mejorar permiso maternidad / paternidad", 1, 1),
		new Question("Aumentar salario mínimo", 1, 1),
		// PvsC
		new Question("Monarquía no, república sí", 2, 1),
		new Question("Independencia por referéndum", 2, 1),
		new Question("Aborto sin restricciones", 2, 1),
		new Question("Eutanasia", 2, 1),
		new Question("Mejor dentro Europa", 2, 1),
		new Question("Derecho de manifestación sagrado", 2, 1),
		new Question("Contra la cadena perpétua", 2, 1),
		new Question("Lucha contra la inmigración", 2, 1),
		new Question("Escuela sin religión", 2, 1),
		new Question("Candidatos por primarias", 2, 1),
		new Question("Lucha contra la corrupción", 2, 1),
		new Question("Medioambiente prioritario", 2, 1),
		new Question("Antitaurinos (animalistas)", 2, 1),
		new Question("Contra la recentralización", 2, 1),
		new Question("El senado debería desaparecer", 2, 1),
		new Question("Menos bipartidismo", 2, 1)
    };
    // colors
	public static Color bgColor = newRGBColor(255, 255, 255);
    public static Color[] questionColors = {
		// les preguntes alternen el color de fons en funció dels colors pastel (eliminar conflictius)
		newRGBColor(149,100,173),
		//newRGBColor(244,111,110),
		newRGBColor(31,184,222),
		newRGBColor(27,211,177),
		newRGBColor(250,187,59)
    };
	// methods
	public static Color newRGBColor(int red, int green, int blue, int alpha = 255) {
		return new Color(red/255f, green/255f, blue/255f, alpha/255f);
	}
}