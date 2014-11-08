using UnityEngine;
using System.Collections;

public class Button_Option : MonoBehaviour {

	public Texture2D TTitle;
	public Texture2D TSound;
	public Texture2D TColor;
	public Texture2D TExplanation;

	void OnGUI() {

		int upMargin = Screen.height / 16;
		int leftMargin = Screen.width / 8;
		int buttonWidth = Screen.width * 6 / 8;
		int buttonHeight = Screen.height * 3 / 16;

		// ボタンを表示する
		if (GUI.Button(new Rect(leftMargin, upMargin, buttonWidth, buttonHeight), TTitle)) {

		}
		if (GUI.Button(new Rect(leftMargin, upMargin * 2 + buttonHeight, buttonWidth, buttonHeight), TSound)) {

		}
		if (GUI.Button(new Rect(leftMargin, upMargin * 3 + buttonHeight * 2, buttonWidth, buttonHeight), TColor)) {

		}
		if (GUI.Button(new Rect(leftMargin, upMargin * 4 + buttonHeight * 3, buttonWidth, buttonHeight), TExplanation)) {

		}
	}
}
