using System.Collections.Generic;
using AssemblyCSharp;
using UnityEngine;
using System.Collections;

public class FunctionFactory : MonoBehaviour {

	public int difficulty = 0;
	private static int lastFunction = 999;

    private static List<IFunction> funcs = new List<IFunction>()
    {
        new LinearFunction(),
        new ParaboraFunction(),
        new SinFunction(),
        new CosFunction(),
        new Discrete1Function(),
        new TailerSinFunction()
	};

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static IFunction getFunction(int minLevel, int maxLevel){
		int rnd = 0;
	    if (funcs.Count == 0) return null;
		do {
			rnd = Random.Range (0,funcs.Count);
		} while(rnd == lastFunction && funcs[rnd].functionLevel < minLevel && funcs[rnd].functionLevel > maxLevel);
		lastFunction = rnd;
		return funcs[rnd];
	}
}
