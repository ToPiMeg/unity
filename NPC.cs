using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 3; //zve�ejn� prom�nnou health, s hodnotou 3

    public int level = 2; //zve�ejn� prom�nnou level, s hodnotu 2

    public float speed = 1.2f; //zve�ejn� prom�nnou float, s hodnotou 1.2

    // Start is called before the first frame update
    void Start()
    {
        health += level; //p�i�te levely do �ivot�
        print(health); //odevzd� �ivoty
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
