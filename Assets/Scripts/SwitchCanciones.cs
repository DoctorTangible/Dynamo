using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCanciones
{
    public static List<Notas> Selección(string Nombre)
    {
        List<Notas> Listatronco = null;

        switch (Nombre)
        {
            case "Test":
                if (Controlador.yo.Dificultad == _Dificultad.Facil)
                {
                    Listatronco = Test.Facil();
                }

                if (Listatronco == null) { Debug.LogError("POR EL PUTO AMOR DE DIOS, EN SERIO TIO?"); }
                Listatronco = Controlador.Ordenador(Listatronco);
                return Listatronco;

            default:
                Debug.LogError(Nombre + "Que coño es esto tio?");

                return null;
        }        
    }
}
