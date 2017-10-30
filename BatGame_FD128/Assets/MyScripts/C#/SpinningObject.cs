using UnityEngine;
using System.Collections;

public class SpinningObject : MonoBehaviour {
	public float SpinSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float amtToMove = SpinSpeed * Time.deltaTime;
		transform.Rotate (Vector3.up * amtToMove);
	
	}
}
