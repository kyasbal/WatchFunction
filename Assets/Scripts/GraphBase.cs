using UnityEngine;
using System.Collections;

public class GraphBase : MonoBehaviour {

    public Vector2 vect;

    public GameObject Marker;

    public bool IsLock = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(IsLock)return;
        if (Input.GetMouseButton(0)) {
            vect = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        } else if (Input.touchCount > 0) {
            Touch touch;
            touch = Input.GetTouch(0);
            vect = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 1));
        }
        Marker.gameObject.transform.position=new Vector3(vect.x,vect.y,0);
	}

    public Vector2 mouseVector2 {
				get {
						return vect*5;	
				}
		}
}
