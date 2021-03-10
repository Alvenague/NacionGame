using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

	bool B;
	public bool lanzaJ;
	public bool lanzaS;
	public Dado1 Dado;

	 
	bool numRan=false;

	private float lerpTime = 5;
	private float currentLerpTime = 0;

	void Start () {
			
		B = false;
		lanzaJ= false;
		lanzaS= false;
	}


	public void OnClick()
	{	if (B == false) {


			B = true;
			Invoke ("io", 5);
			GameObject info = GameObject.Find ("d6");
			Dado.setEstado ();
			info.SendMessage ("Dado");




		}

	}

	public void io(){	B = false;	}
	public bool getTurnoJ() 	{return lanzaJ;	}
	public void setTurnoJ(bool x){  lanzaJ = x;	}


	public void Update()
	{
		//recCasilla = 666;
		/*
		if(	Dado.getNumDado () < 7 && numRan == false)
		{
			numRan = true;
			posIni = Personaje.transform.position;


			recCasilla = Dado.getNumDado ();
			valorD += recCasilla;
			nomCasilla = valorD.ToString ();
			CasillaDest = GameObject.Find ("5");

			posFin= CasillaDest.transform.position;
		}
		if (lanzaJ == true && numRan == true) {
			

			currentLerpTime += Time.deltaTime;

			if(currentLerpTime>=lerpTime)
			{
				currentLerpTime = lerpTime;
			}

			float perc = currentLerpTime / lerpTime;
			Personaje.transform.position = Vector3.Lerp (posIni,posFin,perc);

		}*/
	}

}
