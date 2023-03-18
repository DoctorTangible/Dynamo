using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borra : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RectTransform rt = GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(100, 200);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
