using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Test
{
    public static List<Notas> Facil()
    {
        Controlador.Tiempo = 0;
        S1();
       
        return Controlador.ListaEditable;
    }

    private static void S1()
    {
        Controlador.Insertar(1, new Vector2(1, 0), "+2.5", TipoNota.Azul, Orientación.Abajo);
    }
}
