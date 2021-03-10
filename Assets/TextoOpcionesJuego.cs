using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextoOpcionesJuego : MonoBehaviour {

	//private GameObject TextoJuego;
	private OpcionesJuego	TextoJuego ;
	private Text texto;
	void Start () {
		TextoJuego = GameObject.Find ("OpcionesJuego").GetComponent<OpcionesJuego>();
	
		texto = GetComponent<Text>();

	}

	void Update () {
		texto.text ="Etnia: "+ TextoJuego.getEtnia()+" Dificultad: "+TextoJuego.getDificultad();
	}
}
