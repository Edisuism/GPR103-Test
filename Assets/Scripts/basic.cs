using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basic : MonoBehaviour
{
    public Enemy enemyScript;
    public int ammoCount = 10;
    public bool isEmpty = true;
    public string gunName = "George";
    public float fireDelay = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        enemyScript.GetEnemyHealth();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Add(int ammoToAdd)
    {
        ammoCount += ammoToAdd;
        Debug.Log(ammoCount);
    }

    private void Subtract(int ammoToSubtract)
    {
        ammoCount -= ammoToSubtract;
        Debug.Log(ammoCount);
    }


}
