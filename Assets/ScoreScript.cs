using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	public Score mainScore;
	int tempScore;
	TextMesh text3D;
	public float rotateSpeed;
	public Transform playerRotation;
	public float scoreSpeed = 1000F;
	Vector3 scorePosition;
	float angle;
	// Use this for initialization
	void Start () {
		text3D =GetComponent<TextMesh>();
		scorePosition.z = transform.position.z;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
		{
			angle = Mathf.Atan2(-Input.acceleration.x, Input.acceleration.y) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.AngleAxis(angle -180F,Vector3.forward), rotateSpeed);
			
		}
		else 
		{
			transform.rotation = Quaternion.Slerp(transform.rotation,playerRotation.rotation, rotateSpeed);
		}
		
		
		
		mainScore.AddScore((int)(Time.deltaTime *scoreSpeed));



		text3D.text = mainScore.GetScore().ToString();
		//		scorePosition.x = Camera.main.transform.position.x;
		//	scorePosition.y = Camera.main.transform.position.y;
	}
}
