using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//Uzglabā ainā esošo kanvu
	public Canvas kanva;
	//GameObject, kas uzglabās velkamos objektus
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject ugunsDzes;
	public GameObject e46;
	public GameObject vW;
	public GameObject trak1;
	public GameObject trak2;
	public GameObject cements;
	public GameObject police;
	public GameObject konstr;
	//Uzglabā velakmo objektu sākotnējās atrašanās vietas koordinātas
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 ugunsKoord; 
	[HideInInspector]
	public Vector2 e46Koord;
	[HideInInspector]
	public Vector2 vWKoord;
	[HideInInspector]
	public Vector2 policKoord;
	[HideInInspector]
	public Vector2 trak1Koord;
	[HideInInspector]
	public Vector2 trak2Koord;
	[HideInInspector]
	public Vector2 cementKoord;
	[HideInInspector]
	public Vector2 KonstrKoord;
	//Uzglabās audio avotu, kurā atskaņot attēlu skaņas efektus
	public AudioSource skanasAvots;
	//Masīvs, kas uzglabā visas iespējamās skaņas
	public AudioClip[] skanaKoAtskanot;
	//Mainīgais piefiksē vai objekts nolikts īstajāvietā (true/false)
	[HideInInspector]
	public bool vaiIstajaVieta = false;
	//Uzglabās pēdējo objektu, kurš pakustināts
	public GameObject pedejaisVIlktais = null;

	// Use this for initialization
	void Start () {
		atkrKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		atroKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		bussKoord = autobuss.GetComponent<RectTransform> ().localPosition;
		ugunsKoord = ugunsDzes.GetComponent<RectTransform> ().localPosition;
		e46Koord = e46.GetComponent<RectTransform> ().localPosition;
		vWKoord = vW.GetComponent<RectTransform> ().localPosition;
		policKoord = autobuss.GetComponent<RectTransform> ().localPosition;
		trak1Koord = trak1.GetComponent<RectTransform> ().localPosition;
		trak2Koord = trak2.GetComponent<RectTransform> ().localPosition;
		cementKoord = cements.GetComponent<RectTransform> ().localPosition;
		KonstrKoord = konstr.GetComponent<RectTransform> ().localPosition;

	}
}
