using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    public AnimationCurve curve;
    public Vector3 targetGoal;
    public float speed = 0.5f;
    private float current, target;


    // Start is called before the first frame update
    void Start()
    {

        float numberThing = 10 % 3;
        Debug.Log("Number thing: " + numberThing);
    }

    // Update is called once per frame
    void Update()
    {
        //target = target <= 1 ? 1 : 0; // if target == 0, then do the first thing, otherwise do the second thing

        if (current == target) target = target == 0 ? 1 : 0;

        current = Mathf.MoveTowards(current, target, speed * Time.deltaTime);

        transform.position = Vector3.Lerp(Vector3.zero, targetGoal, curve.Evaluate(current));
    }
}
