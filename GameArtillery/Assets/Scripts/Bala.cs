using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
	public GameObject particulasExplosion;
	public float timeExplose = 3f;
	AdministradorJuego adminJuego;
	
	void Start()
	{
		adminJuego = GameObject.Find("AdministradorJuego").GetComponent<AdministradorJuego>();
	}
	
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.CompareTag("Suelo"))
		{
			Invoke("Explotar", timeExplose);
		}
		if (col.gameObject.CompareTag("Obstaculo"))
		{
			Explotar();
		}
	}
	
	public void Explotar()
	{
		GameObject particula = Instantiate(particulasExplosion, transform.position,Quaternion.identity) as GameObject;
		adminJuego.Bloqueado = false;
		SeguirCamara.objetivo = null;
		Destroy(gameObject);
	}
}
