using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fdsa : MonoBehaviour
{
    public AudioClip cancion;
    public _Dificultad Dificultad;
    public List<penis> rublos = new List<penis>();
    private AudioSource sexo;
    public static fdsa yo;

    void Start()
    {
        if (yo != null) { return; }
        yo = this;

        Application.targetFrameRate = 60;
        sexo = GetComponent<AudioSource>();
        StartCoroutine(Reproducir());
        float lel = cansex.sida();
        float lol = cansex.sidote();

        /*
        for (int i = 0; i <rublos.Count; i++)
        {
            rublos[i].partituramierda = distribuidor(rublos[i].nombre);
        }
        */

        for (int i = 0; i < rublos.Count; i++)
        {
            cansex.yo.SendMessage(rublos[i].nombre, rublos[i]);
        }
    }

    IEnumerator Reproducir()
    {
        yield return null;
        float total = cancion.samples;
        sexo.clip = cancion;
        sexo.Play();
        Transform putas = GameObject.Find("FOLLAR").transform;

        double current = (double)(sexo.timeSamples / cancion.samples) * cancion.length;
        double ult = current;
        float utimotiempo = (float)ult;
        float utilizar = 0;
        int exit = 0;

        yield return null;

        while (true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                sexo.Pause();

                while (true)
                {
                    yield return null;

                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        break;
                    }

                }

                sexo.UnPause();

            }
            utimotiempo = utilizar;

            yield return null;

            current = (double)(sexo.timeSamples / cancion.samples) * cancion.length;

            if (sexo.timeSamples == cancion.samples) { Debug.Log("SE ACABÓ!"); yield break; }

            if(sexo.timeSamples == 0)
            {
                exit++;
                if (exit == 3)
                {
                    Debug.Log("SE ACABÓ!"); yield break;
                }
            }
            else
            {
                exit = 0;
            }

            if (current != ult)
            {
                utilizar = (float)current;
                //ult = (float)current;                
                ult = current;                
            }
            else
            {
                utilizar = utilizar + Time.deltaTime;
            }
            

            //yield return null;

            Debug.Log(utilizar);
            //Debug.Log(current);

            putas.position += Vector3.right * 3 * (utilizar - utimotiempo);

        }
    }
    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        int layerMask = 1 << 8;
        layerMask = ~layerMask;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask, QueryTriggerInteraction.Collide))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
        }

    }

    /*
    List<penisman> distribuidor(string nom)
    {
        List<penisman> milista = null;

        switch (nom)
        {
            case "El retorno de willyrex":
                milista = cansex.man(Dificultad);
                break;
            
            default:
                break;
        }

        return milista;
    }

    */

}

[System.Serializable]
public class penis
{
    public string nombre;
    public int lol;
    public Image fotopolla;
    public List<penisman> partituramierda;
}

[System.Serializable]
public class penisman
{
    public string nombre;
    public int lol;
    public Image fotopolla;

    public penisman(string nombre2, int lol2, Image fotopolla2)
    {
        nombre = nombre2;
        lol = lol2;
        fotopolla = fotopolla2;
    }
}
