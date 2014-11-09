using UnityEngine;

public abstract class FunctionControllerBase:MonoBehaviour
{
	public Vector2 Scaling=Vector2.one;
	public float Opacity=1;
	public Vector3 BaseColor=Vector3.one;

	public void Update()
	{
		Vector4 scalingInPassing = new Vector4 (this.Scaling.x, this.Scaling.y, 0, 0);
		renderer.material.SetFloat ("_O", Opacity);
		renderer.material.SetVector ("_Scaling", scalingInPassing);
		this.OnUpdateFunction ();
	}

	protected abstract void OnUpdateFunction();
}