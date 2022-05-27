using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorRun : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator myAnim;

    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            myAnim.Play("Run_1");
            GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);
            GetComponent<SpriteRenderer>().flipX = false;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            myAnim.Play("Run_1");
            GetComponent<Rigidbody2D>().velocity = new Vector2(-5, 0);
            GetComponent<SpriteRenderer>().flipX = true;
        }

        else if (Input.GetKey(KeyCode.Space))
        {
            myAnim.Play("jumpy");
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100)) ;
        }

        else
        {
            myAnim.Play("Idle_1");
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);

        }

    }
}
