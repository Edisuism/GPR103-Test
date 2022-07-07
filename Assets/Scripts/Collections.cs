using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
    public GameObject[] exampleArray = new GameObject[5];
    public Transform[] potentialPos;
    public GameObject enemy;
    private Enemy script;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemy, potentialPos[Random.Range(0,3)]);

    }

    // Update is called once per frame
    void Update()
    {
        //script.enemyName;
    }
}
