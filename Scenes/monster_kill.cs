using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_kill : MonoBehaviour
{
    public AudioClip kill_sound;
    public Transform kill_effect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "player")
        {
            Instantiate(kill_effect, other.transform.position, other.transform.rotation);
            
        }
    }

    
}
