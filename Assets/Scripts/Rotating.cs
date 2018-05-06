using UnityEngine;
using System.Collections;

public class Rotating : MonoBehaviour {
	public Vector3 speed;
	Quaternion rotation;
//	public float speed = 10F;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rotation = transform.rotation;
//		transform.Rotate(speed * Time.deltaTime);
		rotation.eulerAngles += speed  * Time.deltaTime;
		transform.rotation = rotation;
	}
}
