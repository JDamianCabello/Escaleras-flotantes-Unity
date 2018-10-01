using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Giro : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	System.Random rnd = new System.Random();
	// Update is called once per frame
	void Update () {
		
		int maximo = 20; 
		transform.Rotate(rnd.Next(maximo),rnd.Next(maximo),rnd.Next(maximo));
	}
}
