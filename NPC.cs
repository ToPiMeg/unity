using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 3; //zveøejní promìnnou health, s hodnotou 3

    public int level = 2; //zveøejní promìnnou level, s hodnotu 2

    public float speed = 1.2f; //zveøejní promìnnou float, s hodnotou 1.2

    // Start is called before the first frame update
    void Start()
    {
        health += level; //pøiète levely do životù
        print(health); //odevzdá životy
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
