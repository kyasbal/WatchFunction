using UnityEngine;
using System.Collections;
namespace Functions.PrefabController{
public class LinearFunctionController:FunctionControllerBase
{

	public float A;

	public float B;

	protected override void OnUpdateFunction ()
	{
		renderer.material.SetFloat ("_A", this.A);
		renderer.material.SetFloat ("_B", this.B);
	}

}
}