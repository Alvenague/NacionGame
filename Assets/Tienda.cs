using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
//using UnityEditor;

public class Tienda : MonoBehaviour {

	public  Image MObjeto1;
	public  Image MObjeto2;
	public  Image MObjeto3;
	public int numeroObj;
	public int ValorDinero;
	string obj1;
	string obj2;
	string obj3;
	string objMision;
	OpcionesJuego	TextoJuego ;
	Movimiento	Dinero ;
	ObjetosComprados	ObjComprados ;

	int[]   valorObjeto = new int[]{2,1,1,2,3,1,3,3,2};

	public int cantOro;
	public int catPlata;

	public Text PlataT;
	public Text OroT;
	//public Text TextoInformacion;
	public GameObject infoText;
	public GameObject btninfo;
	public GameObject imageText;

	int cantidadDinero;
	void Start () {
		TextoJuego = GameObject.Find ("OpcionesJuego").GetComponent<OpcionesJuego>();
		Dinero = GameObject.Find ("CharacterList").GetComponent<Movimiento>();
		ObjComprados = GameObject.Find ("GameController").GetComponent<ObjetosComprados>();
		//infoText = GameObject.Find ("TextoInfo");//.GetComponent<Text> ().text = cadena;
		infoText.SetActive (false);
		btninfo.SetActive (false);
		imageText.SetActive (false);

	}

	// Update is called once per frame
	void Update () {

		PlataT.text = Dinero.getCantidadPlata().ToString ();
		OroT.text = 	Dinero.getCantidadOro().ToString ();

	

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

	public void ComprarObjeto1()
	{
		cantOro=Dinero.getCantidadOro();
		catPlata=Dinero.getCantidadPlata();
		objMision = TextoJuego.getObejtosMision ();
		obj1=objMision.Substring(0,2);
		numeroObj = System.Int32.Parse (obj1);
		ValorDinero = valorObjeto [numeroObj-1];
		cantidadDinero = (cantOro * 2) + catPlata;
		if(cantidadDinero>ValorDinero)
		{	
			Debug.Log ("Se puede comprar el Objeto");
			if(ValorDinero == 1 && catPlata >=1)
			{	
				Debug.Log ("Se compro el producto");
				Dinero.setCantidadPlata (catPlata-1);
			} 

			if(ValorDinero == 2 && (catPlata >=2|| cantOro >=1))
			{	
				Debug.Log ("Se compro el producto");
				if(catPlata >=2)
				{
					Dinero.setCantidadPlata (catPlata-2);
				}
				if(cantOro >=1)
				{
					Dinero.setCantidadOro(cantOro-1);
				}

			} 

			if(ValorDinero == 3 && catPlata >=1 && cantOro >=1)
			{	
				Debug.Log ("Se compro el producto");
				if(catPlata >=1 && cantOro >=1)
				{
					Dinero.setCantidadPlata (catPlata-1);
					Dinero.setCantidadOro(cantOro-1);
				}
				if(catPlata >=3)
				{
					Dinero.setCantidadPlata (catPlata-3);
				}

			} 

			ObjComprados.ActivarP1 ();
			ObjComprados.ActivarT1 ();

			infoText.SetActive (true);
			btninfo.SetActive (true);
			imageText.SetActive (true);


			ReadString (TextoJuego.getEtnia(),obj1);

		} else
		{	
			Debug.Log ("No hay suficiente dinero");
		} 


				
	}

	public void ComprarObjeto2()
	{


		cantOro=Dinero.getCantidadOro();
		catPlata=Dinero.getCantidadPlata();
		objMision = TextoJuego.getObejtosMision ();
		obj2=objMision.Substring(3,2);
		numeroObj = System.Int32.Parse (obj2);
		ValorDinero = valorObjeto [numeroObj-1];
		cantidadDinero = (cantOro * 2) + catPlata;
		if(cantidadDinero>ValorDinero)
		{	
			Debug.Log ("Se puede comprar el Objeto");
			if(ValorDinero == 1 && catPlata >=1)
			{	
				Debug.Log ("Se compro el producto");
				Dinero.setCantidadPlata (catPlata-1);
			} 

			if(ValorDinero == 2 && (catPlata >=2|| cantOro >=1))
			{	
				Debug.Log ("Se compro el producto");
				if(catPlata >=2)
				{
					Dinero.setCantidadPlata (catPlata-2);
				}
				if(cantOro >=1)
				{
					Dinero.setCantidadOro(cantOro-1);
				}

			} 

			if(ValorDinero == 3 && catPlata >=1 && cantOro >=1)
			{	
				Debug.Log ("Se compro el producto");
				if(catPlata >=1 && cantOro >=1)
				{
					Dinero.setCantidadPlata (catPlata-1);
					Dinero.setCantidadOro(cantOro-1);
				}
				if(catPlata >=3)
				{
					Dinero.setCantidadPlata (catPlata-3);
				}

			} 

			ObjComprados.ActivarP2 ();
			ObjComprados.ActivarT2 ();

			infoText.SetActive (true);
			btninfo.SetActive (true);
			imageText.SetActive (true);


			ReadString (TextoJuego.getEtnia(),obj2);
		} else
		{	
			Debug.Log ("No hay suficiente dinero");
		} 



	}

	public void ComprarObjeto3()
	{
		cantOro=Dinero.getCantidadOro();
		catPlata=Dinero.getCantidadPlata();
		objMision = TextoJuego.getObejtosMision ();
		obj3=objMision.Substring(6);
		numeroObj = System.Int32.Parse (obj3);
		ValorDinero = valorObjeto [numeroObj-1];
		cantidadDinero = (cantOro * 2) + catPlata;
		if(cantidadDinero>ValorDinero)
		{	
			Debug.Log ("Se puede comprar el Objeto");
			if(ValorDinero == 1 && catPlata >=1)
			{	
				Debug.Log ("Se compro el producto");
				Dinero.setCantidadPlata (catPlata-1);
			} 

			if(ValorDinero == 2 && (catPlata >=2|| cantOro >=1))
			{	
				Debug.Log ("Se compro el producto");
				if(catPlata >=2)
				{
					Dinero.setCantidadPlata (catPlata-2);
				}
				if(cantOro >=1)
				{
					Dinero.setCantidadOro(cantOro-1);
				}

			} 

			if(ValorDinero == 3 && catPlata >=1 && cantOro >=1)
			{	
				Debug.Log ("Se compro el producto");
				if(catPlata >=1 && cantOro >=1)
				{
					Dinero.setCantidadPlata (catPlata-1);
					Dinero.setCantidadOro(cantOro-1);
				}
				if(catPlata >=3)
				{
					Dinero.setCantidadPlata (catPlata-3);
				}

			} 
			ObjComprados.ActivarP3 ();
			ObjComprados.ActivarT3 ();

			infoText.SetActive (true);
			btninfo.SetActive (true);
			imageText.SetActive (true);


			ReadString (TextoJuego.getEtnia(),obj3);

		} else
		{	
			Debug.Log ("No hay suficiente dinero");
		} 



	}

	public void infoLeida()
	{	
		infoText.SetActive (false);
		btninfo.SetActive (false);
		imageText.SetActive (false);

	}


	//[MenuItem("Tools/Read file")]
	public void ReadString(string etnia, string arch)
	{	string path = "Assets/Resources/"+etnia+"/"+arch+".txt";
		StreamReader reader = new StreamReader(path); 
		string cadena = reader.ReadToEnd().ToString();
		infoText.GetComponent<Text> ().text = cadena;
		 Debug.Log(reader.ReadToEnd());
		reader.Close();
	}
}
