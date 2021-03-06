﻿using UnityEngine;
using System.Collections;

public class ChunkCheck : MonoBehaviour {
	static int currentChunkType= 1;
	public int ChangeToChunk;
	int randomInt;
	public Transform objParent;
	GameObject tempObject;
//	RandomChunkManager 
	public GameObject[] ChunksType1;
	public GameObject[] ChunksType2;
	public GameObject[] ChunksType3;
	// Use this for initialization
	void Start () {
		currentChunkType = ChangeToChunk;
		objParent = transform.parent;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.z < 0F){

			if(currentChunkType == 1){
				randomInt = (int) Mathf.Floor( Random.Range(0,ChunksType1.Length-0.01F));
				tempObject =Instantiate(ChunksType1[randomInt],transform.position+ (Vector3.forward*40F),Quaternion.identity) as GameObject;
			}
			if(currentChunkType == 2){
				randomInt = (int) Mathf.Floor( Random.Range(0,ChunksType2.Length-0.01F));
				tempObject =Instantiate(ChunksType2[randomInt],transform.position+ (Vector3.forward*40F),Quaternion.identity) as GameObject;
			}

			if(currentChunkType == 3){
				randomInt = (int) Mathf.Floor( Random.Range(0,ChunksType3.Length-0.01F));
				tempObject =Instantiate(ChunksType3[randomInt],transform.position+ (Vector3.forward*40F),Quaternion.identity) as GameObject;
			}
			tempObject.transform.parent = objParent;
			Destroy(gameObject); 


		}
	}


}
