using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Canon : MonoBehaviour
{
	[SerializeField]
	GameObject BalaPrefab;
	GameObject puntaCanon;
	float rotaticion;
	float fuerza;
	public Image fuerzaImg;
	[SerializeField]
	GameObject ParticulaDisparo;
	public AudioClip clipDisparo;
	AudioSource SourceDisparo;
	public AudioClip clipExplosion;
	AudioSource SourceExplocion;
	
	AdministradorJuego adminJuego;
	int totalDisparos;
	
	CanonControls canonC;
	InputAction apuntar;
	InputAction modificarFuerza;
	InputAction disparar;
	
	void Awake()
	{
		canonC = new CanonControls();
	}
	
	void OnEnable()
	{
		apuntar = canonC.Canon.Apuntar;
		modificarFuerza = canonC.Canon.ModificarFuerza;
		disparar = canonC.Canon.Disparar;
		
		apuntar.Enable();
		modificarFuerza.Enable();
		disparar.Enable();
		
		disparar.performed += Disparar;
	}
	
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
	    //rotaticion += Input.GetAxis("Horizontal") * adminJuego.VelocidadRotacion;
	    rotaticion += apuntar.ReadValue<float>() * adminJuego.VelocidadRotacion;
	    
	    fuerza += modificarFuerza.ReadValue<float>() * 1;
	    fuerzaImg.fillAmount = fuerza/adminJuego.VelocidadBala;
	    
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
	    
	    if (fuerza > adminJuego.VelocidadBala)
	    {
	    	fuerza = adminJuego.VelocidadBala;
	    }
	    if (fuerza < 0)
	    {
	    	fuerza = 0.3f;
	    }
    }
    
	void Disparar(InputAction.CallbackContext context)
	{
		if (totalDisparos > 0)
		{
			GameObject temp = Instantiate(BalaPrefab, puntaCanon.transform.position, transform.rotation);
			Rigidbody tempRB = temp.GetComponent<Rigidbody>();
			SeguirCamara.objetivo = temp;
			Vector3 direccionDisparo = transform.rotation.eulerAngles;
			direccionDisparo.y = 90 - direccionDisparo.x;
			Vector3 direccionParticula = new Vector3(-90 + direccionDisparo.x,90,0);
			GameObject particula = Instantiate(ParticulaDisparo,puntaCanon.transform.position,Quaternion.Euler(direccionParticula));
			tempRB.velocity = direccionDisparo.normalized * fuerza;
			SourceDisparo.PlayOneShot(clipDisparo);
			SourceExplocion.PlayOneShot(clipExplosion);
			totalDisparos--;
			adminJuego.Bloqueado = true;
		}
		else
		{
			adminJuego.PerderJuego();
		}
	}
}
