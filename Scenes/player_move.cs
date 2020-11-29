using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    Rigidbody rb;
    float speed = 30f;
    //private float player_speed = 50.0f;
    //private float rot_speed = 120.0f;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");

        Vector3 getVel = new Vector3(xMove, 0, zMove) * speed;
        rb.velocity = getVel;

    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "monster")
        {
            other.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }

}
