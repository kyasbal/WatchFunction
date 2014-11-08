using UnityEngine;
using System.Collections;

public class Button_MainMenu : MonoBehaviour {

	public Texture TTitle;
	public Texture TEndless;
	public Texture TPvP;

	void OnGUI() {

		// ボタンを表示する
		if (GUI.Button(new Rect(20, 20, 100, 50), TTitle)) {

		}
		if (GUI.Button(new Rect(20, 40, 100, 50), TEndless)) {

		}
		if (GUI.Button(new Rect(20, 60, 100, 50), TPvP)) {

		}
	}
}