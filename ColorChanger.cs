using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        ChangeColor(color);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeColor(Color c)
    {
        GetComponent<Renderer>().material.color = c;
    }
}
