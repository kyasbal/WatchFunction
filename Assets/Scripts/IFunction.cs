﻿using UnityEngine;
using System.Collections;

public abstract class IFunction:MonoBehaviour
{
    public GameObject ContentObject;

    public abstract void Refresh();
	public abstract void DrawGraph(float time);
    public abstract void BeginDraw(GameManager gameManager);
	public abstract bool IsHit(Vector2 player);
	public abstract string functionName { get; }
	public abstract int functionLevel { get; }

    public abstract float waitingTimeInSecound { get; }

	protected GameObject GetGraphArea()
	{
		return GameObject.FindGameObjectWithTag ("GraphArea");
	}

    public abstract void DrawFormula(GameManager gameManager);
}
