using UnityEngine;
using System.Collections;
namespace Functions.PrefabController{
public class TanFunctionController:FunctionControllerBase
{

	public float A;

	public float B;

    public float C;

	protected override void OnUpdateFunction ()
	{
		renderer.material.SetFloat ("_A", this.A);
		renderer.material.SetFloat ("_B", this.B);
	    renderer.material.SetFloat ("_C", this.C);
	}

}
}