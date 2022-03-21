using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour {

	public Objekti objektuSkripts;
	
	// Update is called once per frame
	void Update () {
		
		//kopets no stackoverflow:)
		if(objektuSkripts.timeAC==true){
			//objektuSkripts.timee += Time.deltaTime;
			//Man radas kluda par time deltaTime, ari transformacijas skripta
		}
	}
}
