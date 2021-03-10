using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OpcionesJuego : MonoBehaviour {


	public string Dificultad="" ;
	public string Etnia = "";
	public string Personaje = "";
	public string ObjetosMision="";
	//public Text texto;
	//Vectores donde se almacenaran los tipos de mision
	public string[]   OFacil = new string[]{"01-02","03-04","06-04","02-05","03-07","06-08","01-04","09-04","01-09"};
	public string[]   ODificil = new string[]{"01-04-05","03-01-07","06-09-08","02-08-01","03-09-05","06-04-07","02-09-07","03-04-08","06-01-05"};

	public static OpcionesJuego estadoJuego;

	void Awake(){
		if(estadoJuego==null){
			estadoJuego = this;
			DontDestroyOnLoad(gameObject);
		}else if(estadoJuego!=this){
			Destroy(gameObject);
		}
	}


	public void Uru(){Etnia = "Uru";	}
	public void Quechua(){	Etnia = "Quechua";	}
	public void Aymara(){Etnia = "Aymara";	}
	public void Facil()	{Dificultad= "Facil";	}
	public void Dificil(){Dificultad = "Dificil";	}
	public string getDificultad(){ 	return Dificultad;	}
	public string getEtnia(){return Etnia;	}
	public string getObejtosMision(){return ObjetosMision;	}
	public void setMision(string dificultad, int i)
	{ 	

		if (dificultad.Equals ("Facil")) {
			ObjetosMision=OFacil[i];
		} 

		if (dificultad.Equals ("Dificil")) {
			ObjetosMision=ODificil[i];
		} 

	}
	void Start () {
		
	}





}

