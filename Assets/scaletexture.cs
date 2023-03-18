using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaletexture : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.SetTextureScale("_MainTex", new Vector2(2, 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
