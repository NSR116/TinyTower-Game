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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            targetPosotion.x++;

            if(targetPosotion.x >= 16.4f)
            {
                targetPosotion.x = 16.4f;
            }
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            targetPosotion.x--;

            if(targetPosotion.x <= -26.6f)
            {
                targetPosotion.x = -26.6f;
            }
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            targetPosotion.y++;

            if(targetPosotion.y >= 100)
            {
                targetPosotion.y = 100;
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            targetPosotion.y--;

            if(targetPosotion.y <= 1)
            {
                targetPosotion.y = 1;
            }
        }

        transform.position = Vector3.Lerp(transform.position, targetPosotion, 0.03f);
            
    }
}
