using UnityEngine;
using System.Collections;

public class FunctionPrefabContainer : MonoBehaviour
{

    public static FunctionPrefabContainer instance;

    public FunctionPrefabContainer()
    {
        instance = this;
    }

    public GameObject LinearGameObject;

    public GameObject ParaboraGameObject;

    public GameObject SinGameObject;

    public GameObject CosGameObject;

	public GameObject LogGameObject;

    public GameObject SecantGameObject;


    public GameObject Discrete1GameObject;
}
