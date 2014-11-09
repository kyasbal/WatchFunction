using UnityEngine;
using System.Collections;

public class GraphBase : MonoBehaviour {

    private Vector2 vect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0)) {
            vect = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        } else if (Input.touchCount > 0) {
            Touch touch;
            touch = Input.GetTouch(0);
            vect = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 1));
        }
	}

    public Vector2 mouseVector2 {
				get {
						return vect;	
				}
		}
}
