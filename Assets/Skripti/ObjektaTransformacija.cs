using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektaTransformacija : MonoBehaviour {
	public Objekti objektuSkripts;

	// Update is called once per frame
	void Update () {
		if (objektuSkripts.pedejaisVIlktais != null) {
			if (Input.GetKey (KeyCode.Z)) {
				objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().transform.Rotate (0, 0, Time.deltaTime * 9f);
			}

			if (Input.GetKey (KeyCode.X)) {
				objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().transform.Rotate (0, 0, -Time.deltaTime * 9f);
			}

			if (Input.GetKey (KeyCode.UpArrow)) {
				if(objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform>().transform.localScale.y < 0.8f){
					objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().transform.localScale
					= new Vector2 (objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform>().transform.localScale.x,
						objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform>().transform.localScale.y + 0.001f);
				}
			}

			if (Input.GetKey (KeyCode.DownArrow)) {
				if(objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform>().transform.localScale.y > 0.3f){
					objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().transform.localScale
					= new Vector2 (objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform>().transform.localScale.x,
						objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform>().transform.localScale.y - 0.001f);
				}
			}

			if (Input.GetKey (KeyCode.LeftArrow)) {
				if(objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform>().transform.localScale.x > 0.3f){
					objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().transform.localScale
					= new Vector2 (objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform>().transform.localScale.x - 0.001f,
						objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform>().transform.localScale.y);
				}
			}

			if (Input.GetKey (KeyCode.RightArrow)) {
				if(objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform>().transform.localScale.x < 0.8f){
					objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform> ().transform.localScale
					= new Vector2 (objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform>().transform.localScale.x + 0.001f,
						objektuSkripts.pedejaisVIlktais.GetComponent<RectTransform>().transform.localScale.y);
				}
			}
		}
	}
}