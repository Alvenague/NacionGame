using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Villano : MonoBehaviour {
	public bool visita;
	int aleatorio;
	Movimiento	Dinero ;
	public Text textoAdv;

	bool objetoOcupado;

	ObjetosComprados	ObjComprados ;
	void Start () {
		objetoOcupado = false;
		ObjComprados = GameObject.Find ("GameController").GetComponent<ObjetosComprados>();
		Dinero = GameObject.Find ("CharacterList").GetComponent<Movimiento>();
		visita=false;

	}

	void Update () {

		if(visita)
		{
			visita = false;
			aleatorio = Random.Range (1, 3);

			if(aleatorio == 1 )
			{
				Debug.Log ("Pierdes un objeto");
				//  Se pierde un Objeto
				if (ObjComprados.obj1 ==true && objetoOcupado ==false ) {
					objetoOcupado = true;
					ObjComprados.DesactivarP1 ();
					ObjComprados.DesactivarT1 ();
				} 

				if (ObjComprados.obj2 ==true && objetoOcupado ==false  ) {
					objetoOcupado = true;
					ObjComprados.DesactivarP2 ();
					ObjComprados.DesactivarT2 ();
				} 

				if (ObjComprados.obj3 ==true && objetoOcupado ==false ) {
					objetoOcupado = true;
					ObjComprados.DesactivarP3 ();
					ObjComprados.DesactivarT3 ();
				} 
				
			}

			if(aleatorio == 2)
			{//  Se pierde una moneda oro


				if (Dinero.getCantidadOro() >= 1) {
					Dinero.setCantidadOro (Dinero.getCantidadOro () - 1);
					Debug.Log ("Pierdes una moneda de oro");
					textoAdv.text = "Pierdes una moneda de oro";
				}
				else {
					textoAdv.text = "No tienes la cantidad de monedas";
					
				}
			}

			if(aleatorio == 3)
			{//  Se pierde dos monedas de plata
				
				if (Dinero.getCantidadPlata () >= 2) {
					Dinero.setCantidadOro (Dinero.getCantidadPlata () - 1);
					Debug.Log ("Pierdes dos monedas de plata");
					textoAdv.text = "Pierdes dos monedas de plata";
				} else {
					textoAdv.text = "No tienes la cantidad de monedas";
				}
			}
		}


	}

	void OnTriggerEnter(Collider Other)
	{
		if(Other.gameObject.name=="Niño" || Other.gameObject.name=="Niña" )
		{
			visita=true;
			objetoOcupado = false;
			Debug.Log ("Villano **** "+Other.gameObject.name);
		}

	}
}
