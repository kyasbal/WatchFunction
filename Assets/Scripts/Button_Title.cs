﻿using UnityEngine;
using System.Collections;

public class Button_Title : MonoBehaviour {

	public Texture2D TTitle;
	public Texture2D TGameMode;
	public Texture2D TOption;
	public Texture2D TTwitter;
	public Texture2D TFacebook;
	public Texture2D TGoogleplus;

	void OnGUI() {

		int upMargin = Screen.height / 16;
		int leftMargin = Screen.width / 8;
		int buttonWidth = Screen.width * 6 / 8;
		int buttonHeight = Screen.height * 3 / 16;

		// ボタンを表示する
		if (GUI.Button(new Rect(leftMargin, upMargin, buttonWidth, buttonHeight), TTitle)) {

		}
		if (GUI.Button(new Rect(leftMargin, upMargin * 2 + buttonHeight, buttonWidth, buttonHeight), TGameMode)) {

		}
		if (GUI.Button(new Rect(leftMargin, upMargin * 3 + buttonHeight * 2, buttonWidth, buttonHeight), TOption)) {

		}/*
		if (GUI.Button(new Rect(65, 230, 50, 50), TTwitter)) {

		}
		if (GUI.Button(new Rect(115, 230, 50, 50), TFacebook)) {

		}
		if (GUI.Button(new Rect(165, 230, 50, 50), TGoogleplus)) {

		}*/
	}
}