using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dios : MonoBehaviour
{
    public GameObject terreno;
    public float offset;
    public int terrenosCreados;

	private void Start()
	{
		CrearTerreno();
		CrearTerreno();
		///////////////// Optimizar con Coroutine /////////////////////
		InvokeRepeating("CrearTerreno", 0, 5); 
	}

	[ContextMenu("Crear terreno nuevo")]
    public void CrearTerreno()
	{
        Vector3 pos = offset * terrenosCreados * Vector3.forward;
		///////////////// Optimizar con Pool /////////////////////
		Instantiate(terreno, pos, Quaternion.Euler(90, 0, 0));
        terrenosCreados++;
	}
}
