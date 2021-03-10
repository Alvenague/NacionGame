using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class Movimiento : MonoBehaviour {


	Transform _destination;
	NavMeshAgent _navMeshAgent;
	public NavMeshAgent Villano;
	public GameObject DestinoP;
	public GameObject DestinoV;
	public int numDado;

	private Click	Boton ;
	public Dado1	Dado ;

	public int	casillaP=0 ;
	public int	casillaV=0 ;

	public Text PlataT;
	public Text OroT;

	public int Plata=1;
	public int Oro = 0;

		

	void Start () {
		_navMeshAgent = this.GetComponent<NavMeshAgent>();
		Boton = GameObject.Find ("GameController").GetComponent<Click>();
		//Dado = GameObject.Find ("d6").GetComponent<Dado1>();
	}
	


	void Update () {
		
		PlataT.text = Plata.ToString ();
		OroT.text = Oro.ToString ();
		if (Boton.getTurnoJ ()) {
			StartCoroutine("setDestination");
		//setDestination ();

		}
	}

	IEnumerator   setDestination()
	{
		Vector3 targetVectorP;
		Vector3 targetVectorV;
		numDado = Dado.getNumDado ();


			if (numDado <= 3) {
				casillaP += numDado;
				DestinoP = GameObject.Find (casillaP.ToString ());
				targetVectorP = DestinoP.transform.position;
				_navMeshAgent.SetDestination (targetVectorP);
			}
			if (numDado == 4) {
				casillaP += 1;
				casillaV += 1;
				DestinoP = GameObject.Find (casillaP.ToString ());
				DestinoV = GameObject.Find ("Casilla Villano_" + casillaV.ToString ());
				targetVectorP = DestinoP.transform.position;
				targetVectorV = DestinoV.transform.position;
				_navMeshAgent.SetDestination (targetVectorP);
				Villano.SetDestination (targetVectorV);
			}

			if (numDado == 5) {
				casillaP += 2;
				casillaV += 1;
				DestinoP = GameObject.Find (casillaP.ToString ());
				DestinoV = GameObject.Find ("Casilla Villano_" + casillaV.ToString ());
				targetVectorP = DestinoP.transform.position;
				targetVectorV = DestinoV.transform.position;
				_navMeshAgent.SetDestination (targetVectorP);
				Villano.SetDestination (targetVectorV);
			}
			if (numDado == 6) {

				casillaV += 2;
		
				DestinoV = GameObject.Find ("Casilla Villano_" + casillaV.ToString ());

				targetVectorV = DestinoV.transform.position;
		
				Villano.SetDestination (targetVectorV);
			}

			if (DestinoP.tag.Equals ("casilla_naranja")) {
				Plata += 1;
			}
			if (DestinoP.tag.Equals ("casilla_amarilla")) {
				Oro += 1;
			}


			if (DestinoP.tag.Equals ("casilla_celeste")) {
			
			}

	
		Boton.setTurnoJ(false);

		yield return null;
	}

	public string getTagCasilla()
	{
		return DestinoP.tag;
	}

	public int getCantidadOro()
	{
		return Oro;
	}

	public int getCantidadPlata()
	{
		return Plata;
	}

	public void setCantidadOro(int i)
	{
		 Oro=i;
	}

	public void setCantidadPlata(int i)
	{
		Plata = i;
	}
}
