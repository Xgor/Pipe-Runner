using UnityEngine;
using System.Collections;

public class highScoreScr : MonoBehaviour {
	public Score mainScore;
	// Use this for initialization
	void Start () {
		guiText.text = "High Score: " + mainScore.GetHighScore().ToString();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
