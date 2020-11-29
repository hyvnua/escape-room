using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_move : MonoBehaviour
{
    [SerializeField]
    private float speed = 100.0f;
    public float rot_angle = 15.0f;
    public UnityEngine.AI.NavMeshAgent agent;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float current_angle = rot_angle * Time.deltaTime;
        MoveToTarget();
        
        this.transform.LookAt(target);
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(this.transform.position, fwd, out hit, 5) == false || hit.collider.gameObject.tag != "player")
            return;


    }

    void MoveToTarget()
    {
        agent.SetDestination(target.transform.position);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "player")
        {
            other.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
