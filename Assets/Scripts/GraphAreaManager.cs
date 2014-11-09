using UnityEngine;
using System.Collections;

public class GraphAreaManager : MonoBehaviour
{
    private GameObject lastObject;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeGameObject(GameObject obj)
    {
        Instantiate(obj);
        lastObject = obj;
    }
}
