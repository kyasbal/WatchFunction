using UnityEngine;
using System.Collections;

public interface IFunction {

	void DrawGraph();

	///<summary>判定用</summary>
	bool IsHit(Player player);

	string functionName;


}