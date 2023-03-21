using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terreno : MonoBehaviour
{
    public GameObject[] objetos;
    public float probabilidad;
    void Start()
    {
		Reforestar();

	}
    void Reforestar()
	{
		for (int i = 0; i < objetos.Length; i++)
		{
            if(Random.Range(0f,1f) < probabilidad)
			{
                objetos[i].SetActive(true);
			}
			else
			{
				objetos[i].SetActive(false);
			}
		}
	}
}
