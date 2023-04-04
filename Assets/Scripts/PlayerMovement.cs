using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 targetPosotion;

    private void Start()
    {
        targetPosotion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            targetPosotion.x++;

            if(targetPosotion.x >= 148.5f)
            {
                targetPosotion.x = 148.5f;
            }
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            targetPosotion.x--;

            if(targetPosotion.x <= -125f)
            {
                targetPosotion.x = -125f;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            targetPosotion.y++;

            if(targetPosotion.y >= 100)
            {
                targetPosotion.y = 100;
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            targetPosotion.y--;

            if(targetPosotion.y <= 1)
            {
                targetPosotion.y = 1;
            }
        }

        transform.position = targetPosotion;            
    }

}
