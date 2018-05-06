using UnityEngine;
using System.Collections;

public class MoveTest : MonoBehaviour {

	bool dead = false;
	bool fallCheck = false;
	float angle;
	public float speed = 10F;

	public Score mainScore;

	public Move mainMove;

//	public float walkSpeed = 10F;
	
	public GameObject[] allPipes;



	// Use this for initialization
	void Start () {
	//	allPipes = GameObject.FindGameObjectsWithTag("Chunk");

	}
	
	// Update is called once per frame
	void Update () {


//		Input.GetAxis("Horizontal");
		allPipes = GameObject.FindGameObjectsWithTag("Pipe");

		if(!dead)
		{
		//	walkSpeed += Time.deltaTime * 0.01F;

			if(fallCheck){
				print("WHY");


				dead = !(Physics.Raycast(Camera.main.transform.position, -transform.up,100));


			}
			fallCheck = !(Physics.Raycast(Camera.main.transform.position, -transform.up,100));
			Debug.DrawRay(Camera.main.transform.position, -transform.up*100);


			transform.Rotate(0,0,Input.GetAxis("Horizontal")*speed * Time.deltaTime);

			if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer){
				angle = Mathf.Atan2(-Input.acceleration.x, Input.acceleration.y) * Mathf.Rad2Deg;
	//			transform.rotation = 

				transform.rotation = Quaternion.AngleAxis(angle -180F,Vector3.forward);
				//transform.Rotate(0,0,Input.acceleration.x *speed * Time.deltaTime);
			}





		} else {
			transform.Translate(Vector3.down * Time.deltaTime * 9F);


			mainMove.speed -= Time.deltaTime * 4F;
			if(Mathf.Abs(transform.position.x) + Mathf.Abs(transform.position.y) > 10){
				Lost();
			}
		}


	//	for(int i = 0;i < allPipes.Length;i++){
	//		allPipes[i].transform.Translate(0,0,-walkSpeed * Time.deltaTime);
			
//		}

		
	}
	
	void OnCollisionEnter(Collision collisionInfo) 
	{
		print("I'm hit");

	}
	void Lost (){
		mainScore.RestartScore();
		Application.LoadLevel(Application.loadedLevel);

	}
}
