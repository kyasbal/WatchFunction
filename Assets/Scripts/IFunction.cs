using UnityEngine;
using System.Collections;

public interface IFunction{

	void DrawGraph();

	///<summary>判定用</summary>
	bool IsHit(Vector2 player);

	string functionName { get; }


}


public class QuizFunctions : IFunction{

	private string name;
	private string pic;
	private int level = 0;

	public void DrawGraph (){
		
	}

	public bool IsHit (Vector2 player){

		return true;//TODO
	}

	public string functionName {
		get {
			return name;
		}
	}

	public void setFunction(string n, string p, int l){
		name = n;
		pic = p;
		level = l;
	}

	public int functionLevel {
		get {
			return level;
		}
	}
}
