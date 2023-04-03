using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomInstantiation : MonoBehaviour
{
    [SerializeField] private GameObject []arrayRoom = new GameObject[4];
    [SerializeField] private GameObject panel;

    public void createRoom(int index)
    {
        panel.SetActive(false);
        Instantiate(arrayRoom[index], new Vector3(0, 0, 0), Quaternion.identity);

        GameManager.instance.calculateMoney(index);
    }
}
