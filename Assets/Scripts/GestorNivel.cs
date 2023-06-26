using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorNivel : MonoBehaviour
{
    public string NombreElegido;
    public Canciones Elegido;
    private AudioSource AS;
    private float utilizar;
    private List<Notas> Partitura = new List<Notas>();

    void Start()
    {
        for (int i = 0; i < Controlador.yo.ListaCanciones.Count; i++)
        {
            if (NombreElegido == Controlador.yo.ListaCanciones[i].Nombre)
            {
                Elegido = Controlador.yo.ListaCanciones[i];
                break;
            }
        }
        if (Elegido.Nombre == "") { Debug.LogError("OH NO, NO HAY CANCI�N ASIGNADA. VAMOS A MORIR TODOS JODER ME CAGO EN LA PUTA!!!!"); }
        AS = GetComponent<AudioSource>();
        StartCoroutine(Reproducir());
    }

    IEnumerator Reproducir()
    {
        Partitura = SwitchCanciones.Selecci�n(NombreElegido);

        yield return null;
        yield return null;
        yield return null;

        float total = Elegido.Canci�n.samples;
        AS.clip = Elegido.Canci�n;
        AS.Play();

        double CurrentSamples = (double)(AS.timeSamples / Elegido.Canci�n.samples) * Elegido.Canci�n.length;
        double LastSample = CurrentSamples;
        float utimotiempo = (float)LastSample;
        utilizar = 0;
        int exit = 0;

        yield return null;

        while (true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                AS.Pause();

                while (true)
                {
                    yield return null;

                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        break;
                    }

                }

                AS.UnPause();

            }
            utimotiempo = utilizar;

            yield return null;

            CurrentSamples = (double)(AS.timeSamples / Elegido.Canci�n.samples) * Elegido.Canci�n.length;

            if (AS.timeSamples == Elegido.Canci�n.samples) { Debug.Log("SE ACAB�!"); yield break; }

            if (AS.timeSamples == 0)
            {
                exit++;
                if (exit == 3)
                {
                    Debug.Log("SE ACAB�!"); yield break;
                }
            }
            else
            {
                exit = 0;
            }

            if (CurrentSamples != LastSample)
            {
                utilizar = (float)CurrentSamples;              
                LastSample = CurrentSamples;
            }
            else
            {
                utilizar = utilizar + Time.deltaTime;
            }


            //yield return null;

            Controlador.CurrentTime = utilizar;
            Debug.Log(utilizar);
            //Debug.Log(current);

            //putas.position += Vector3.right * 3 * (utilizar - utimotiempo);

        }
    }
}

