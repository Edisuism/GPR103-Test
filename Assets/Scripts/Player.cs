using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer renderer;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        //If i press down w + d
        // 0,0,0
        // 1,0,0
        // 1,1,0
        // a^2 + b^2 = c^2

        Vector3 direction = Vector3.zero; // Vector3(0,0,0)
        direction.x = Input.GetAxisRaw("Horizontal"); // i i don't press a or d, return 0
        direction.y = Input.GetAxisRaw("Vertical"); //if i press w, return 1
        direction = Vector3.ClampMagnitude(direction, 1);
        transform.position += direction * speed * Time.deltaTime;


        animator.SetFloat("Speed", Mathf.Abs(direction.x + direction.y));
        renderer.flipX = direction.x < 0;
    }
}
