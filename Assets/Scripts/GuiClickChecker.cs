using UnityEngine;
using System.Collections;

public class GuiClickChecker : MonoBehaviour
{

    public Vector3 TapPoint;
    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
}
