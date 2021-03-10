using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetosComprados : MonoBehaviour {

	public  GameObject PObjeto1;
	public  GameObject PObjeto2;
	public  GameObject PObjeto3;
	public  GameObject TObjeto1;
	public  GameObject TObjeto2;
	public  GameObject TObjeto3;

	public bool obj1;
	public bool obj2;
	public bool obj3;

	void Start () {

	   obj1=false;
		obj2=false;
		obj3=false;
		//PObjeto1.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void ActivarP1()
	{		PObjeto1.SetActive (true);	obj1 = true;}
	public void ActivarP2()
	{		PObjeto2.SetActive (true);	obj2 = true;}
	public void ActivarP3()
	{	PObjeto3.SetActive (true);	obj2 = true;}
	public void ActivarT1()
	{	TObjeto1.SetActive (true);	}
	public void ActivarT2()
	{		TObjeto2.SetActive (true);	}
	public void ActivarT3()
	{		TObjeto3.SetActive (true);	}

	public void DesactivarP1()
	{	PObjeto1.SetActive (false);	}
		public void DesactivarP2()
	{	PObjeto2.SetActive (false);		}
	public void DesactivarP3()
	{	PObjeto3.SetActive (false);	}
	public void DesactivarT1()
	{
		TObjeto1.SetActive (false);
	}

	public void DesactivarT2()
	{
		TObjeto2.SetActive (false);	
	}
	public void DesactivarT3()
	{
		TObjeto3.SetActive (false);	
	}
}
