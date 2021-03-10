using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chiwiña : MonoBehaviour {

	//public GameObject Dado;
	public FollowCamera Configuracion;
	public Movimiento TagCasilla;
	public GameObject panel;
	public GameObject IrTienda;
	public GameObject NoIrTienda;

	void Start () {
		Configuracion = GameObject.Find ("FollowCamera").GetComponent<FollowCamera> ();
		TagCasilla = GameObject.Find ("CharacterList").GetComponent<Movimiento> ();
		//panel=GameObject.Find("Panel");
		//IrTienda=GameObject.Find("Comprar");
		//sNoIrTienda=GameObject.Find("Volver");
		//IrTienda=GameObject.("Comprar");
		IrTienda.SetActive (false);
		NoIrTienda.SetActive (false);
		panel.SetActive (false);
	
	}

	void Update () {
		
	}


	void OnTriggerEnter(Collider Other)
	{    
		Debug.Log ("Casilla de chiwiña");
		Debug.Log (TagCasilla.getTagCasilla());

		if(TagCasilla.getTagCasilla().Equals("casilla_celeste"))
		{
				
		Configuracion.DesactivarBotones ();
		IrTienda.SetActive (true);
		NoIrTienda.SetActive (true);


		}
	
	}


	public void Comprar()
	{

		IrTienda.SetActive (false);
		NoIrTienda.SetActive (false);
		panel.SetActive (true);

	}


	public void Volver()
	{
		IrTienda.SetActive (false);
		NoIrTienda.SetActive (false);
		Configuracion.ActivarBotones ();
	}
	public void Aceptar()
	{
		IrTienda.SetActive (false);
		NoIrTienda.SetActive (false);
		panel.SetActive (false);
		Configuracion.ActivarBotones ();
	}
}
