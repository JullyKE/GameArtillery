using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
	[SerializeField]
	GameObject BalaPrefab;
	GameObject puntaCanon;
	float rotaticion;
	[SerializeField]
	GameObject ParticulaDisparo;
	public AudioClip clipDisparo;
	AudioSource SourceDisparo;
	public AudioClip clipExplosion;
	AudioSource SourceExplocion;
	
	AdministradorJuego adminJuego;
	int totalDisparos;
	
    void Start()
	{
		adminJuego = GameObject.Find("AdministradorJuego").GetComponent<AdministradorJuego>();
	    puntaCanon = transform.Find("PuntaCanon").gameObject;
		totalDisparos = adminJuego.DisparosPorJuego; 
		SourceDisparo = GameObject.Find("SonidoDisparo").GetComponent<AudioSource>();
		SourceExplocion = GameObject.Find("SonidoExplosion").GetComponent<AudioSource>();
    }

    void Update()
    {
	    rotaticion += Input.GetAxis("Horizontal") * adminJuego.VelocidadRotacion;
	    if (rotaticion <= 90 && rotaticion >= 0)
	    {
	    	transform.eulerAngles = new Vector3(rotaticion, 90, 0f);
	    }
	    if (rotaticion > 90)
	    {
	    	rotaticion = 90;
	    }
	    if (rotaticion < 0)
	    {
	    	rotaticion = 0;
	    }
	    
	    if (Input.GetKeyDown(KeyCode.Space) &&  totalDisparos > 0 && !adminJuego.Bloqueado)
	    {
	    	GameObject temp = Instantiate(BalaPrefab, puntaCanon.transform.position, transform.rotation);
	    	Rigidbody tempRB = temp.GetComponent<Rigidbody>();
	    	SeguirCamara.objetivo = temp;
	    	Vector3 direccionDisparo = transform.rotation.eulerAngles;
	    	direccionDisparo.y = 90 - direccionDisparo.x;
	    	Vector3 direccionParticula = new Vector3(-90 + direccionDisparo.x,90,0);
	    	GameObject particula = Instantiate(ParticulaDisparo,puntaCanon.transform.position,Quaternion.Euler(direccionParticula));
	    	tempRB.velocity = direccionDisparo.normalized * adminJuego.VelocidadBala;
	    	SourceDisparo.PlayOneShot(clipDisparo);
	    	SourceExplocion.PlayOneShot(clipExplosion);
	    	totalDisparos--;
	    	adminJuego.Bloqueado = true;
	    }
    }
}
