using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorJuego : MonoBehaviour
{
	public static AdministradorJuego SingletonAdiministradorJuego;
	
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
}
