using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBall : MonoBehaviour {

	private Vector3 initialPosition;
	private float time;
	private float minTime = 2;
	private float maxTime = 5;
	private float initBallTime;
	private bool initBall;
	public static int countBall { get; set; }

	void Start ()
	{
		initialPosition = new Vector3 (-5.5f, -0.2f, -3.5f);
		initBall = false;
		time = 0;
		Debug.Log ("time set to 0!");
		countBall = 0;
		transform.position = initialPosition;
		SetRandomTime ();
		Debug.Log ("initBallTime set!");
	}

	void FixedUpdate ()
	{
		time += Time.deltaTime;
		if (time < initBallTime) {
			initBall = false;
			Debug.Log ("case1, init: " + initBall + " and  time: " + time + " and countBall: " + countBall);
		} else if (initBallTime <= time && time <= (maxTime + 4.5f)) {
			initBall = true;
			Debug.Log ("case2, init: " + initBall + " and  time: " + time + " and countBall: " + countBall);
		} else if (time > maxTime + 2) {
			Debug.Log ("countBall: " + countBall + " and  time: " + time);
			initBall = false;
			time = 0;
			countBall += 1;
			SetRandomTime ();
		}

		switch (initBall) 
		{
		case true:
			ballProcessing();
			break;
		case false:
			transform.position = initialPosition;
			Debug.Log ("initialPosition is set!");
			break;
		}
	}

	void ballProcessing ()
	{
		transform.position += new Vector3 (0.02f, 0, 0f);
	}

	void SetRandomTime ()
	{
		initBallTime = Random.Range (minTime, maxTime);
		Debug.Log ("initBallTime: " + initBallTime + " and time: " + time);
	}

	public int GetCountBall () {
		return countBall;
	}
}