using UnityEngine;
using System.Collections;

public class ParticleScript : MonoBehaviour {

	public Move move;
	ParticleSystem particles;

	// Use this for initialization
	void Start () {
		particles = gameObject.GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {

		particles.startSpeed = move.speed*1.1f;
	}
}
