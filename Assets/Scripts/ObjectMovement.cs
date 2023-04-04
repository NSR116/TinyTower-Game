using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class ObjectMovement : MonoBehaviour
{

    [SerializeField] private GameObject indicatorObj;
    [SerializeField] private GameObject []arrayPoints = new GameObject[4];
    public bool isPlaced = false;

    // Update is called once per frame
    void Update()
    {
        if (isPlaced)
        {
            return;
        }

        moveWithMouse();

        if(isValidPlace() && Input.GetMouseButtonDown(0))
        {
            isPlaced = true;
        }
    }

    /// <summary>
    /// This method used to move created room with mouse position
    /// </summary>
    void moveWithMouse()
    {
        Vector3 mouse = Input.mousePosition;
        mouse.z = -Camera.main.transform.position.z + 3.7f;

        mouse = Camera.main.ScreenToWorldPoint(mouse);
        transform.position = new Vector3(Mathf.Round(mouse.x), Mathf.Round(Mathf.Clamp(mouse.y, 0f, 100f)), mouse.z);
    }

    /// <summary>
    /// This method used to check if created room in a valid place to put it or not
    /// </summary>
    /// <returns></returns>
    bool isValidPlace()
    {
        for(int i =0; i<arrayPoints.Length; i++)
        {
            if (!Physics.Raycast(arrayPoints[i].transform.position, Vector3.down, 1f))
            {
                indicatorObj.SetActive(true);
                return false;
            }
        }

        indicatorObj.SetActive(false);
        return true;
    }
}
