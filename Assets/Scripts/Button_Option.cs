using UnityEngine;
using System.Collections;

public class Button_Option : MonoBehaviour {

	public Texture TTitle;
	public Texture TSound;
	public Texture TColor;
	public Texture TExplanation;

	void OnGUI() {

		// ボタンを表示する
		if (GUI.Button(new Rect(20, 20, 100, 50), TTitle)) {

		}
		if (GUI.Button(new Rect(20, 40, 100, 50), TSound)) {

		}
		if (GUI.Button(new Rect(20, 60, 100, 50), TColor)) {

		}
		if (GUI.Button(new Rect(20, 60, 100, 50), TExplanation)) {

		}
	}
}
