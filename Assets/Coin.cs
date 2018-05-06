using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
	public int pointsGet;
	public Score mainScore;
	public GameObject coinSound;


	void OnTriggerEnter() 
	{
		
		print("I'm hit");
		mainScore.AddScore(pointsGet);
		Instantiate(coinSound);
		Destroy(gameObject);

	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
