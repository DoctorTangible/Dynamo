using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timerputa : MonoBehaviour
{

    float sexo;

    public void penis()
    {
        GetComponent<TextMeshProUGUI>().text = (Time.time - sexo).ToString();
        sexo = Time.time;
    }
}
