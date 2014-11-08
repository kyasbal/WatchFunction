using UnityEngine;
using System.Collections;

public class FunctionFactory : MonoBehaviour {

	public int difficulty = 0;
	private static int lastFunction = 999;

	private static QuizFunctions[] funcs = new QuizFunctions[100];

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static IFunction getFunction(int minLevel, int maxLevel){
		int rnd = 0;
		do {
			rnd = Random.Range (0, 100);
		} while(rnd == lastFunction && funcs[rnd].functionLevel < minLevel && funcs[rnd].functionLevel > maxLevel);
		lastFunction = rnd;
		return funcs[rnd];
	}
}
