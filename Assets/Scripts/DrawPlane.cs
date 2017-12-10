using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPlane : MonoBehaviour {

	private TrailRenderer tr;
	private RandomBall rb;
	private int cb;


	void Start()
	{
		tr = GetComponent<TrailRenderer>();
		tr.time = 1000000;
		rb = new RandomBall ();
	}

	void Update () {

		if (tr) {
			
			if ((Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) || Input.GetMouseButton (0)) {
				Plane myPlane = new Plane (Camera.main.transform.forward, this.transform.position);

				Ray mRay = Camera.main.ScreenPointToRay (Input.mousePosition);
				float rayDistance;

				if (myPlane.Raycast (mRay, out rayDistance))
					tr.transform.position = mRay.GetPoint (rayDistance);
			}
		} else {
			tr = GetComponent<TrailRenderer> ();
		}
	}

	void LateUpdate () {
		cb = rb.GetCountBall ();
		if (cb == 4)
			tr.Clear();
	}
}