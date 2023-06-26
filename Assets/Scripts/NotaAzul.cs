using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotaAzul : MonoBehaviour
{
    public float llegada;

    void Start()
    {
        
    }

    void Update()
    {
        float posy = (llegada - Controlador.CurrentTime) * ((43.47f / 1.084f) * (Controlador.Velocidad / 0.8f));
        //(2s - variable) x 8m / s = 16m


        //43.47 altura para 1.084s
        //40.104f en 1sS
    }
}
