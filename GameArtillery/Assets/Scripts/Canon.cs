using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
	[SerializeField]
	GameObject BalaPrefab;
	GameObject puntaCanon;
	float rotaticion;
	
	int totalDisparos;
	
    void Start()
    {
	    puntaCanon = transform.Find("PuntaCanon").gameObject;
	    totalDisparos = AdministradorJuego.SingletonAdiministradorJuego.DisparosPorJuego;
    }

    void Update()
    {
	    rotaticion += Input.GetAxis("Horizontal") * AdministradorJuego.SingletonAdiministradorJuego.VelocidadRotacion;
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
	    
	    if (Input.GetKeyDown(KeyCode.Space) &&  totalDisparos > 0)
	    {
	    	GameObject temp = Instantiate(BalaPrefab, puntaCanon.transform.position, transform.rotation);
	    	Rigidbody tempRB = temp.GetComponent<Rigidbody>();
	    	Vector3 direccionDisparo = transform.rotation.eulerAngles;
	    	direccionDisparo.y = 90 - direccionDisparo.x;
	    	tempRB.velocity = direccionDisparo.normalized * AdministradorJuego.SingletonAdiministradorJuego.VelocidadBala;
	    	totalDisparos--;
	    }
    }
}
