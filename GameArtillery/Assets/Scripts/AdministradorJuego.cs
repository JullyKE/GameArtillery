using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdministradorJuego : MonoBehaviour
{
	public static AdministradorJuego SingletonAdiministradorJuego;
	
	public GameObject canvasOver;
	public GameObject canvasWin;
	
	private static int _VelocidadBala = 30;
	public int VelocidadBala
	{
		get => _VelocidadBala;
		set => _VelocidadBala = value;
	}
	
	private static int _DisparosPorJuego = 10;
	public int DisparosPorJuego
	{
		get => _DisparosPorJuego;
		set => _DisparosPorJuego = value;
	}
	
	private static float _VelocidadRotacion = 1;
	public float VelocidadRotacion
	{
		get => _VelocidadRotacion;
		set => _VelocidadRotacion = value;
	}
	
	private static bool _Bloqueado = false;
	public bool Bloqueado
	{
		get => _Bloqueado;
		set => _Bloqueado = value;
	}
	
	void Awake()
	{
		if (SingletonAdiministradorJuego == null)
		{
			SingletonAdiministradorJuego = this;
		}
		else
		{
			Debug.Log("Ya existe una instancia de esta clase");
		}
	}
	
	public void GanaraJuego()
	{
		canvasWin.SetActive(true);
		Invoke("MenuGame", 3);
	}
	public void PerderJuego()
	{
		canvasOver.SetActive(true);
		Invoke("MenuGame", 3);
	}
	
	void MenuGame()
	{
		SceneManager.LoadScene("Menu");
	}
}
