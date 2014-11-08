using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainManager : MonoBehaviour {

	public GameObject Player;
	public GameObject PopupText;

	int time;
	int nowLevel;
	public string nowScene;

	void Awake() {
		DontDestroyOnLoad(this);
		nowScene = "MainMenu";
	}

	// Use this for initialization
	void Start() {
		Application.LoadLevel(nowScene);
	}

	// Update is called once per frame
	void Update() {
		switch (nowScene) {
			case "MainMenu":

				break;

			case "GamePlay":

				break;

			case "GameResult":

				break;
		}

	}

}