using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CartasMsion : MonoBehaviour {

	public  Image MObjeto1;
	public  Image MObjeto2;
	public  Image MObjeto3;
	public  string obj1;
	public  string obj2;
	public  string obj3;
	public string objMision;
	public OpcionesJuego	TextoJuego ;

	void Start () {
		
		TextoJuego = GameObject.Find ("OpcionesJuego").GetComponent<OpcionesJuego>();

		//MObjeto1 = GameObject.Find ("Objeto1").GetComponent<Image> ();
		//MObjeto2 =  GameObject.Find ("Objeto2").GetComponent<Image> ();

		//MObjeto1.sprite = Resources.Load<Sprite> ("Objetos/01");
		//MObjeto2.sprite = Resources.Load<Sprite> ("Objetos/02");


	}
	

	void Update () {
	

		if(TextoJuego.getDificultad().Equals("Dificil"))
		{ 
			objMision = TextoJuego.getObejtosMision ();
			obj1=objMision.Substring(0,2);
			obj2=objMision.Substring(3,2);
			obj3=objMision.Substring(6);
			//MObjeto1.sprite
			MObjeto1.sprite = Resources.Load<Sprite> ("Objetos"+TextoJuego.getEtnia()+"/"+obj1);
			MObjeto2.sprite = Resources.Load<Sprite> ("Objetos"+TextoJuego.getEtnia()+"/"+obj2);
			MObjeto3.sprite = Resources.Load<Sprite> ("Objetos"+TextoJuego.getEtnia()+"/"+obj3);
		}

		if(TextoJuego.getDificultad().Equals("Facil"))
		{
			objMision = TextoJuego.getObejtosMision ();
			obj1=objMision.Substring(0,2);
			obj2=objMision.Substring(3);


			MObjeto1.sprite = Resources.Load<Sprite> ("Objetos"+TextoJuego.getEtnia()+"/"+obj1);
			MObjeto2.sprite = Resources.Load<Sprite> ("Objetos"+TextoJuego.getEtnia()+"/"+obj2);
			//MObjeto2=;
		}

	}

	public void siguienteEscena(){
		SceneManager.LoadScene ("Tablero");
	}
}
