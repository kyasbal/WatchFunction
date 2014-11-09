using System;
using UnityEngine;
using System.Collections;

public class CountController : MonoBehaviour
{
    public float RemainSecound;

    public bool IsVisible;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float frac = RemainSecound - (float) Math.Floor(RemainSecound);
	    float scaling = Mathf.Lerp(0.2f, 0.7f, frac);
        gameObject.transform.localScale=new Vector3(scaling,scaling,1);
        renderer.material.SetFloat("_IsVisible",IsVisible?1.0f:0.0f);
        renderer.material.SetFloat("_Index",(float)Math.Ceiling(RemainSecound)-1);
        renderer.material.SetColor("_BaseColor",Color.Lerp(Color.red,Color.yellow,RemainSecound/3f));
	}
}
