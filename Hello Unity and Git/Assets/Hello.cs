using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour {
	public string message;
	public int nStart = 5;
	private int n;

	// Use this for initialization
	void Start () {
		n = nStart;
		Debug.Log(message);
	}
	
	// Update is called once per frame
	void Update () {
		n += 1;
		if (n > 600)
			n = 0;
	}
}
