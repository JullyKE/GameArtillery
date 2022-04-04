using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Objetivo : MonoBehaviour
{
	public UnityEvent GameWon;
	
	public Obstaculo[] obstacules;
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		obstacules = Object.FindObjectsOfType<Obstaculo>();	
	}
	
	// Update is called every frame, if the MonoBehaviour is enabled.
	protected void Update()
	{
		int i = obstacules.Length;
		if (i <= 0)
		{
			GameWon.Invoke();
		}
		obstacules = Object.FindObjectsOfType<Obstaculo>();
	}
}
