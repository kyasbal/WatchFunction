using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class GameManager : MonoBehaviour {
	public GameStatus CurrentStatus;

	// Use this for initialization
	void Start () {
		CurrentStatus = GameStatus.GameStarting;
	}
	void Update () {
		switch (CurrentStatus) {
		case GameStatus.GameStarting:
			break;
		case GameStatus.GameFinishing:
			break;
		case GameStatus.Waiting:
			break;
		case GameStatus.Showing:
			break;
		case GameStatus.Dismissing:
			break;
		default:
			throw new System.ArgumentOutOfRangeException ();
		}
	}
}
