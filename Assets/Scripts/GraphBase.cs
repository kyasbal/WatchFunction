using UnityEngine;
using System.Collections;

public class GraphBase : MonoBehaviour {

    private Vector2 vect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Touch touch;
        if (Input.touchCount > 0) {
            touch = Input.GetTouch(0);
            vect.x = 2 * touch.position.x / renderer.bounds.size.x - 1;
            vect.y = 2 * touch.position.y / renderer.bounds.size.y - 1;
        }
	}

    public Vector2 mouseVector2 {
				get {
						return Vector2.one;	
				}
		}
}
