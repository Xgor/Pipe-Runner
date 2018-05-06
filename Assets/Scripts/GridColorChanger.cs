using UnityEngine;
using System.Collections;

public class GridColorChanger : MonoBehaviour {

	public Material gridMat;
	public float transitionTime = 5f;

	public Color[] colors;

	Color upcomingColor;
	Color previousColor;
//	Color currentColor;

	float transitionLerp = 0;


	// Use this for initialization
	void Start () {
		gridMat.color = colors[0];
		upcomingColor = colors[0];
		previousColor = colors[0];
	}
	
	// Update is called once per frame
	void Update () {
		print((previousColor !=  upcomingColor).ToString());
	//	gridMat.color = currentColor;
		if(previousColor !=  upcomingColor)
		{
			colorTransision();
		}
		else if(Random.Range(0.0f,1000.0f) < 1f)
		{

			previousColor = gridMat.color;
			upcomingColor = colors[Mathf.FloorToInt(Random.Range(0,colors.Length))];

		}
	}

	void colorTransision() {
		gridMat.color = Color.Lerp(previousColor,upcomingColor,transitionLerp);
		transitionLerp += Time.deltaTime / transitionTime;
		if(transitionLerp > 1.0f)
		{
			transitionLerp = 0;
			previousColor=upcomingColor;
		}

	}

    
}
