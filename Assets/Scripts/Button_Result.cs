using UnityEngine;
using System.Collections;

public class Button_Result : MonoBehaviour {

	public Texture2D TGameOver;

	public Texture2D TTitle;
	public Texture2D TRestart;
	public Texture2D TTwitter;
	public Texture2D TFacebook;
	public Texture2D TGoogleplus;

	void OnGUI() {

		int upMargin = Screen.height / 16;
		int leftMargin = Screen.width / 8;
		int buttonWidth = Screen.width * 6 / 8;
		int buttonHeight = Screen.height * 3 / 16;

		// ボタンを表示する
		GUI.Button(new Rect(Screen.width / 2, Screen.height / 2, 1, 1), TGameOver);
		if (GUI.Button(new Rect(leftMargin, upMargin, buttonWidth, buttonHeight), TTitle)) {

		}
		if (GUI.Button(new Rect(leftMargin, upMargin * 2 + buttonHeight, buttonWidth, buttonHeight), TRestart)) {

		}/*
		if (GUI.Button(new Rect(65, 230, 50, 50), TTwitter)) {

		}
		if (GUI.Button(new Rect(115, 230, 50, 50), TFacebook)) {

		}
		if (GUI.Button(new Rect(165, 230, 50, 50), TGoogleplus)) {

		}*/
	}
}
