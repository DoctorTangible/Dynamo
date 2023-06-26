using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;

public enum _Dificultad { Facil, Normal, Dificil };
public enum TipoNota { Azul, Rojo, Amarillo };
public enum Orientaci�n { Abajo, Derecha, Izquierda };

public class Controlador : MonoBehaviour
{
    public _Dificultad Dificultad;
    public List<Canciones> ListaCanciones = new List<Canciones>();
    public static Controlador yo;
    public static List<Notas> ListaEditable = new List<Notas>();

    public static float Tiempo; //Para la edici�n de notas
    public static float CurrentTime; //El tiempo actual de la puta canci�n
    public static float Velocidad = 0.8f; //La velocidad chingona

    public static CultureInfo culture;

    private void Awake()
    {
        if (yo != null) { Destroy(gameObject); }
        yo = this;
        DontDestroyOnLoad(this);

        culture = CultureInfo.InvariantCulture;
    }

    /*
    private void OnEnable()
    {
        int actual = tetas.Count - 1;
        while (true)
        {
            if (actual == -1)
            {
                tetas.Insert(0, a�ademe);
                break;
            }
            if (a�ademe < tetas[actual])
            {
                actual--;
                continue;
            }

            tetas.Insert(actual + 1, a�ademe);
            break;

        }
    }
    */

    public static List<Notas> Ordenador (List<Notas> Lista)
    {
        List<Notas> Entregar = new List<Notas>();

        for (int i = 0; i < Lista.Count; i++)
        {
            int actual = Entregar.Count - 1;
            while (true)
            {
                if (actual == -1)
                {
                    Entregar.Insert(0, Lista[i]);
                    break;
                }
                if (Lista[i].Tiempo < Entregar[actual].Tiempo)
                {
                    actual--;
                    continue;
                }

                Entregar.Insert(actual +1, Lista[i]);
                break;

            }
        }      

        return null;
    }

    public static void Insertar(float Posici�n, Vector2 Escala, string TiempoEditable, TipoNota Nota, Orientaci�n Direcci�n)
    {
        //Procesar info

        float TiempoFinal;
        if (TiempoEditable.StartsWith("+")) {

            TiempoEditable.Replace("+", "");
            TiempoFinal = Tiempo + float.Parse(TiempoEditable, culture);
        }
        else
        {
            TiempoFinal = float.Parse(TiempoEditable, culture);
        }

        Tiempo = TiempoFinal;
        ListaEditable.Add(new Notas(Posici�n, Escala, TiempoFinal, Nota, Direcci�n));
    }
}

[System.Serializable]
public class Canciones
{
    public string Nombre;
    public AudioClip Canci�n;
    public Image Portada;
}

public class Notas
{
    public float Posici�n;
    public Vector2 Escala;
    public float Tiempo;
    public TipoNota Nota;
    public Orientaci�n Direcci�n;

    public Notas(float Posici�n2, Vector2 Escala2, float Tiempo2, TipoNota Nota2, Orientaci�n Direcci�n2)
    {
        Posici�n = Posici�n2;
        Escala = Escala2;
        Tiempo = Tiempo2;
        Nota = Nota2;
        Direcci�n = Direcci�n2;
    }
}