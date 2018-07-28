using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMain : MonoBehaviour {

	public Sprite layer_blue, layer_red;

	void OnMouseDown () {
		GetComponent <SpriteRenderer> ().sprite = layer_red;
	}

	void OnMouseUp () {
		GetComponent <SpriteRenderer> ().sprite = layer_blue;
	}

	void OnMouseUpAsButton () {
		switch (gameObject.name) {
		case "ButtonStart":
            SceneManager.LoadScene("ColectionsTest");
			break;
		case "ButtonExit":
            Application.Quit();
            break;
            case "ButtonAlphabet":
                SceneManager.LoadScene("ScenaEnglish");
                break;
            case "ButtonHistoriTest":
                SceneManager.LoadScene("ScenaHistori");
                break;
            case "ButtonLogigTest":
                SceneManager.LoadScene("GamplayTest");
                break;
            case "ButtonMorphology":
                SceneManager.LoadScene("ScenaMorphology");
                break;
            case "ButtonOverallDevelopment":
                SceneManager.LoadScene("ScenaEducation");
                break;
        case "ButtonBack":
            SceneManager.LoadScene("MainScen");
            break;
                /*
                    Application.OpenURL ("http://google.com");
                    break;
                */
        }
	}
}
