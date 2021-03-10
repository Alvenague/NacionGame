using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dado1 : MonoBehaviour {

	public GameObject dado;
	public int num;
	public int x;
	public int y;
	public int z;
	public Vector3 n1;
	public Vector3 n2;
	public Vector3 n3;
	public Vector3 n4;
	public Vector3 n5;
	public Vector3 n6;
	public Transform target;
	public bool estado=true;
	private Click	Boton ;

	void Start () {
		num = 7;

		Boton = GameObject.Find ("GameController").GetComponent<Click>();
	}
	
	void Update () {


	
		if (num == 0) { dado.transform.Rotate (x, y, z);  }
		if (num == 1) { dado.transform.rotation = Quaternion.Euler(new Vector3(n1.x, n1.y, n1.z)); 
			if (estado) {
				estado = false;
				Boton.setTurnoJ (true);
			}
			}
		if (num == 2) { dado.transform.rotation = Quaternion.Euler(n2.x, n2.y, n2.z); 
			if (estado) {
				estado = false;
				Boton.setTurnoJ (true);
			}}
		if (num == 3) {	dado.transform.rotation = Quaternion.Euler(new Vector3(n3.x, n3.y, n3.z)); 
			if (estado) {
				estado = false;
				Boton.setTurnoJ (true);
			}}
		if (num == 4) { dado.transform.rotation = Quaternion.Euler(n4.x, n4.y, n4.z); 
			if (estado) {
				estado = false;
				Boton.setTurnoJ (true);
			}}
		if (num == 5) { dado.transform.rotation = Quaternion.Euler(n5.x, n5.y, n5.z); 
			if (estado) {
				estado = false;
				Boton.setTurnoJ (true);
			}}
		if (num == 6) { dado.transform.rotation = Quaternion.Euler(new Vector3(n6.x, n6.y, n6.z)); 
			if (estado) {
				estado = false;
				Boton.setTurnoJ (true);
			}}
	
	}
	public void setEstado()
	{ estado =true;
	}
	void Dado()
	{
		num = 0;
		Invoke ("dado1", 5);
	}

	public int getNumDado()
	{
		return num;
	}
	void dado1()
	{
		num = Random.Range (1, 6);
	
	}
}
