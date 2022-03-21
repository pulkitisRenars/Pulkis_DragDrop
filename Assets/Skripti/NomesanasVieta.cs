using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NomesanasVieta : MonoBehaviour, IDropHandler {
	//Uzglabās velkamā objekta un nomešanas lauka z rotāciju,
	// kāarī rotācijas un izmēru pieļaujamo starpību
	private float vietasZrot, velkObjZrot, rotacijasStarpiba, xIzmeruStarp, yIzmeruStarp;
	private Vector2 vietasIzm, velkObjIzm;
	//Norāde uz Objekti skriptu
	public Objekti objektuSkripts;

	//Nostrādās, ja objektu cenšas nomest uz jebkuras nomešanas  vietas
	public void OnDrop(PointerEventData notikums){
		//Pārbauda vai tika vilkts un atlaists vispār kāds objekts
		if (notikums.pointerDrag != null) {
			//Ja nomešanas vietas tags sakrīt ar vilktā objekta tagu
			if (notikums.pointerDrag.tag.Equals (tag)) {
				//Iegūst objekta rotāciju grādos
				vietasZrot = notikums.pointerDrag.GetComponent<RectTransform> ().eulerAngles.z;
				velkObjZrot = GetComponent<RectTransform> ().eulerAngles.z;
				//Aprēkina abu objektu z rotācijas starpību
				rotacijasStarpiba = Mathf.Abs (vietasZrot - velkObjZrot);
				//Līdzīgi kā ar Z rotāciju, jāpiefiksē objektu izmēri pa x un y asīm, kā arī starpība
				vietasIzm = notikums.pointerDrag.GetComponent<RectTransform> ().localScale;
				velkObjIzm = GetComponent<RectTransform> ().localScale;
				xIzmeruStarp = Mathf.Abs (vietasIzm.x - velkObjIzm.x);
				yIzmeruStarp = Mathf.Abs (vietasIzm.y - velkObjIzm.y);


				//Pārbauda vai objektu rotācijas un izmēru starpība ir pieļaujamajās robēžās
				if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
				   && (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1)) {
					objektuSkripts.vaiIstajaVieta = true;
					//Noliktais objekts smuki iecentrējas nomešanas laukā
					notikums.pointerDrag.GetComponent<RectTransform> ().anchoredPosition 
								= GetComponent<RectTransform> ().anchoredPosition;
					//Rotācijai
					notikums.pointerDrag.GetComponent<RectTransform> ().localRotation
								= GetComponent<RectTransform> ().localRotation;
					//Izsmēram
					notikums.pointerDrag.GetComponent<RectTransform> ().localScale
					= GetComponent<RectTransform> ().localScale;

					//Pārbauda tagu un atskaņo atbilstošo skaņas efektu
					switch (notikums.pointerDrag.tag) {
					case "Atkritumi":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [1]);
						break;

					case "Slimnica":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [2]);
						break;

					case "Skola":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [3]);
						break;

					default:
						Debug.Log ("Nedefinēts tags!");
						break;
					}

				}
			
				//Ja objekts nomests nepareizajā laukā
			} else {
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [0]);

				//Objektu aizmet uz sākotnējo pozīciju
				switch (notikums.pointerDrag.tag) {
				case "Atkritumi":
					objektuSkripts.atkritumuMasina.GetComponent<RectTransform> ().localPosition 
							= objektuSkripts.atkrKoord;
					break; 

				case "Slimnica":
					objektuSkripts.atraPalidziba.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.atroKoord;
					break;

				case "Skola":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.bussKoord;
					break;

				case "Rok":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.bussKoord;
					break;

				case "velk":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.bussKoord;
					break;
				case "Stumj":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.bussKoord;
					break;

				case "Ker":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.bussKoord;
					break;

				case "Lido":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.bussKoord;
					break;

				case "dzes":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.bussKoord;
					break;

				case "cemente":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.bussKoord;
					break;

				case "kruiso":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.bussKoord;
					break;
				default:
					Debug.Log ("Nedefinēts tags!");
					break;
				}

			}
		}

		if (objektuSkripts.punkti == 11) {



			objektuSkripts.VicPanel.SetActive(true);
			objektuSkripts.restartBut.SetActive(true);

			objektuSkripts.timeAC = false;
			objektuSkripts.teksts.GetComponent<Text>().enabled = true;

	
		objektuSkripts.teksts.text = "Pabeidzi speli "+Mathf.Round(objektuSkripts.timee).ToString ()+" sekundes!!!";
			if(objektuSkripts.timee<=200) {
	objektuSkripts.star1.SetActive(true);
			}
			if(objektuSkripts.timee<=100) {
		objektuSkripts.star2.SetActive(true);
			}
			if  (objektuSkripts.timee<=50) {
		objektuSkripts.star3.SetActive (true);
			}
		}
	}
}