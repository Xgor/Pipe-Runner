using UnityEngine;
using System.Collections;

public class AlwaysNrotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer){
			transform.rotation = Quaternion.identity;
		}
	}
}
