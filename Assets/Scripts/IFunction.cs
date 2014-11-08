using UnityEngine;
using System.Collections;

public interface IFunction{

	void DrawGraph();

	///<summary>判定用</summary>
	bool IsHit(Vector2 player);

	string functionName { get; }


}