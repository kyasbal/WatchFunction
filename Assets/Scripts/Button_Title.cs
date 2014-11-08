using UnityEngine;
using System.Collections;

public class Button_Title : MonoBehaviour {

	public Texture TTitle;
	public Texture TGameMode;
	public Texture TOption;
	public Texture TTwitter;
	public Texture TFacebook;
	public Texture TGoogleplus;

	void OnGUI() {

		// ボタンを表示する
		GUI.Button(new Rect(20, 20, 100, 50), TTitle);
		if (GUI.Button(new Rect(20, 70, 100, 50), TGameMode)) {

		}
		if (GUI.Button(new Rect(20, 130, 100, 50), TOption)) {

		}
		if (GUI.Button(new Rect(20, 180, 100, 50), TTwitter)) {

		}
		if (GUI.Button(new Rect(20, 230, 100, 50), TFacebook)) {

		}
	}
}