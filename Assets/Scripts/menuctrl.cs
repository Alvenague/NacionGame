using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuctrl : MonoBehaviour {

	public GameObject panel;
	// Your audio clip
	public AudioClip Sonido;

	// the component that Unity uses to play your clip
	public AudioSource FuenteSonido;


	bool estado=false;

   void Start()
	{
		panel = GameObject.Find ("Panel");
		panel.SetActive (estado);
		FuenteSonido = GetComponent<AudioSource> ();
		FuenteSonido.clip = Sonido;
	}

	void Update ()
	{

			//FuenteSonido.Play();	
	}

	public void CargarEscena(string nombreEscena)
	{
		SceneManager.LoadScene (nombreEscena);
	}

	public void Salir(string nombreEscena)
	{
		Application.Quit ();
	}

	public void  instrucciones()
	{
		estado = !estado;
		panel.SetActive (estado);
	}

}
