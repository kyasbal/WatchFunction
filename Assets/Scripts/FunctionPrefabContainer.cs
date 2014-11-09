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
}
