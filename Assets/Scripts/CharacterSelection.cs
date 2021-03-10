using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour {


	private GameObject[]   characterList;
	private OpcionesJuego	TextoJuego ;
	public Text texto;
	float Tiempo=2.0f;

	private int index;



	private void Start()
	{
		//texto = GameObject.Find("TextoAdvertencia").gameObject.GetComponent<Text>();
		texto.text ="";
		index = PlayerPrefs.GetInt ("CharacterSelected");
		characterList = new GameObject[transform.childCount];


		for (int i = 0; i < transform.childCount; i++) {
			characterList[i] = transform.GetChild(i).gameObject;
		}

		foreach (GameObject go in characterList)
		{go.SetActive (false);

		}

		if (characterList[index])
			characterList[index].SetActive (true);
	}

	void Update ()
	{
		
		if(texto.text.Length >5)
		{
		Tiempo -= Time.deltaTime;
		if(Tiempo<=0.0f)

		{
			texto.text ="";
				Tiempo = 2.0f;
		}
	}
	}



	public void ToogleLeft()
	{
		characterList[index].SetActive (false);
		index--;
		if (index < 0) {
			index = characterList.Length - 1;
		}

		characterList [index].SetActive (true);


	}

	public void ToogleRight()
	{
		characterList[index].SetActive (false);
		index++;
		if (index == characterList.Length) {
			index =  0;
		}

		characterList[index].SetActive (true);


	}



	public void EmpezarJuego()
	{
		//string dificultad;
		//int objetosMision;
		TextoJuego = GameObject.Find ("OpcionesJuego").GetComponent<OpcionesJuego>();

		if (TextoJuego.getEtnia ().Length > 2 && TextoJuego.getDificultad ().Length > 2) {

			//objetosMision =Random.Range (0, 8);
			TextoJuego.setMision (TextoJuego.getDificultad (),Random.Range (0, 8));
			PlayerPrefs.SetInt ("CharacterSelected", index);
			SceneManager.LoadScene ("Mision");

		} 

		else {
			texto.text ="Elegir etnia y dificultad";



		}
	}

}
