using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    Light flash_light;
    Transform tr;
    KeyCode[] KeyCode_List;

    void Awake()
    {
        flash_light = GetComponent<Light>();
        tr = this.transform;

        Key_Depoly();
    }

    void Key_Depoly()
    {
        KeyCode_List = new KeyCode[10];

        KeyCode_List[0] = KeyCode.F;
        KeyCode_List[1] = KeyCode.Escape;
    }

    void Update()
    {
        KeyCode result = User_Input();

        if (result == KeyCode_List[0])
        {
            if (flash_light.enabled)
            {
                flash_light.enabled = false;
            }
            else
            {
                flash_light.enabled = true;
            }
        }
    }

    KeyCode User_Input()
    {
        KeyCode result = KeyCode_List[1];

        for(int i=0; i<KeyCode_List.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode_List[i]))
            {
                result = KeyCode_List[i];
            }
        }
        return result;
    }
}
