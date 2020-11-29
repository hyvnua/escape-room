using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click_event : MonoBehaviour
{
    private int count = 0;
    private bool check = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 10 && check == false)
        {
            Debug.Log("Key를 얻었습니다.");
            check = true;
        }
    }

    void OnMouseDown()
    {
        count++;
    }
}
