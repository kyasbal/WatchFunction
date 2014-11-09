using UnityEngine;
using System.Collections;

public abstract class IFunction:MonoBehaviour{

	public abstract void DrawGraph();
	public abstract bool IsHit(Vector2 player);
	public abstract string functionName { get; }
	public abstract int functionLevel { get; }

	protected GameObject GetGraphArea()
	{
		return GameObject.FindGameObjectWithTag ("GraphArea");
	}
}

public abstract class BasicFunctionByMaterial:IFunction
{

}
