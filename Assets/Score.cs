using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	static int score;
	static int highScore;
	// Use this for initialization
	void Start () {
		if(highScore == null){
			highScore = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {

	//	scorePosition.y = Camera.main.transform.position.y;
	}

	public void AddScore(int Score)
	{
		score += Score;
	}
	public int GetScore(){
		return score;
	}
	public int GetHighScore(){
		return highScore;
	}

	public void RestartScore(){
		if(score > highScore)
		{
			highScore = score;
		}
		score = 0;
	}
}
