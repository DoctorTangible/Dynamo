using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class cansex : MonoBehaviour
{
    public static cansex yo;

    private void Awake()
    {
        if (yo != null) { return; }
        yo = this;
    }

    public static float sida()
    {
        return 1;
    }

    public void El_retorno_de_willyrex(penis rublos)
    {
        List<penisman> milista = new List<penisman>();
        _Dificultad Dificultad = fdsa.yo.Dificultad;

        if (Dificultad == _Dificultad.Facil)
        {
            milista = man_Facil();
        }
        else if (Dificultad == _Dificultad.Normal)
        {
            milista = man_Normal();
        }        
        else if (Dificultad == _Dificultad.Dificil)
        {
            milista = man_Dificil();
        }
        else
        {
            Debug.LogError("NO EXISTE ESA DIFICULTAD JODER");
        }

        rublos.partituramierda = milista;
    }

    public static List<penisman> man_Facil()
    {
        List<penisman> milista = new List<penisman>();

        milista.Add(new penisman("HOGGWARTS", 69, null));
        milista.Add(new penisman("HOGGWARTS2", 71, null));

        return milista;
    }

    public static List<penisman> man_Normal()
    {
        List<penisman> milista = new List<penisman>();

        milista.Add(new penisman("DOCTOR TANGIBLE", 69, null));
        milista.Add(new penisman("HAAGGGWAAARTS", 71, null));

        return milista;
    }

    public static List<penisman> man_Dificil()
    {
        List<penisman> milista = new List<penisman>();

        milista.Add(new penisman("TENGO UN MONO PINTAO EN LA CHANCLA", 69, null));
        milista.Add(new penisman("PA QUE CUANDO MIRE ME HAGA UN POCO GRACIA", 71, null));

        return milista;
    }
}

