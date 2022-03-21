using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class uzMenu : MonoBehaviour {

	public void uzIzveelni(){
		SceneManager.LoadScene ("menuStart1",LoadSceneMode.Single);
	}

}
