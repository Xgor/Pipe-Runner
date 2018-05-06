using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float speed = 10F;
//	public bool moving = true;
	public float speedAcceleration = 0.1F;
	public float maxSpeed = 20F;

	public bool useBobbing;

	Animator anim;

	GameObject[] allPipes;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		allPipes = GameObject.FindGameObjectsWithTag("Pipe");


		if(!useBobbing){
			anim.speed = 0;
		}



	}
	
	// Update is called once per frame
	void Update () {


		if(speed < maxSpeed){
			speed += Time.deltaTime * speedAcceleration;
		} else {
			speed = maxSpeed;
		}


		for(int i = 0;i < allPipes.Length;i++){
			allPipes[i].transform.Translate(0,0,-speed * Time.deltaTime);

		}



//		foreach (GameObject pipe in allPipes) {
//			pipe.transform.Translate(0,0,-speed * Time.deltaTime);
//			print("It works");
//			Instantiate(respawnPrefab, respawn.transform.position, respawn.transform.rotation) as GameObject;
//		}

	}
}
