using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int enemyHealth = 100;
    private int enemyHealthCopy;
    public int enemyDamage = 10;
    public string enemyName = "Tim";

    // Start is called before the first frame update
    void Start()
    {
        enemyHealthCopy = GetEnemyHealth();
        enemyHealthCopy += 50;
        Debug.Log("Copy: " + enemyHealthCopy);

        Debug.Log("Main: " + enemyHealth);
        //Debug.Log(GetEnemyHealth());
        //Debug.Log(enemyHealth);

        /*
            if (enemyHealth < 100)
            {
                Debug.Log("Ouch");
            }
            else if(enemyHealth == 100)
            {
                Debug.Log("Haha, can't touch this");
            }

            Debug.Log("End of Start Method");
        */
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
        }

        if (Input.GetKey("down"))
        {
            print("down arrow key is held down");
        }

    }

    public void SwingSword()
    {
        UnityEngine.Debug.Log("They have swung their Sword");
    }

    public void PrintName()
    {
        Debug.Log(enemyName);
    }

    public int GetEnemyHealth()
    {
        return enemyHealth;
    }


}
