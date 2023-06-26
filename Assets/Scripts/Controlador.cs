using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;

public enum _Dificultad { Facil, Normal, Dificil };
public enum TipoNota { Azul, Rojo, Amarillo };
public enum Orientación { Abajo, Derecha, Izquierda };

public class Controlador : MonoBehaviour
{
    public _Dificultad Dificultad;
    public List<Canciones> ListaCanciones = new List<Canciones>();
    public static Controlador yo;
    public static List<Notas> ListaEditable = new List<Notas>();

    public static float Tiempo; //Para la edición de notas
    public static float CurrentTime; //El tiempo actual de la puta canción
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
                tetas.Insert(0, añademe);
                break;
            }
            if (añademe < tetas[actual])
            {
                actual--;
                continue;
            }

            tetas.Insert(actual + 1, añademe);
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

    public static void Insertar(float Posición, Vector2 Escala, string TiempoEditable, TipoNota Nota, Orientación Dirección)
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
        ListaEditable.Add(new Notas(Posición, Escala, TiempoFinal, Nota, Dirección));
    }
}

[System.Serializable]
public class Canciones
{
    public string Nombre;
    public AudioClip Canción;
    public Image Portada;
}

public class Notas
{
    public float Posición;
    public Vector2 Escala;
    public float Tiempo;
    public TipoNota Nota;
    public Orientación Dirección;

    public Notas(float Posición2, Vector2 Escala2, float Tiempo2, TipoNota Nota2, Orientación Dirección2)
    {
        Posición = Posición2;
        Escala = Escala2;
        Tiempo = Tiempo2;
        Nota = Nota2;
        Dirección = Dirección2;
    }
}