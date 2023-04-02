using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomAlignment : MonoBehaviour
{
    [SerializeField] private GameObject rightWall;
    [SerializeField] private GameObject leftWall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        iNear();
    }

    void iNear()
    {
    
        if (Physics.Raycast(leftWall.transform.position, Vector3.left, out RaycastHit hit1, 1f))
        {
            leftWall.SetActive(false);
        }

       else if (Physics.Raycast(rightWall.transform.position, Vector3.right, out RaycastHit hit2, 1f))
        {
            rightWall.SetActive(false);
        }

        else
        {
            leftWall.SetActive(true);
            rightWall.SetActive(true);
        }
    }
}
