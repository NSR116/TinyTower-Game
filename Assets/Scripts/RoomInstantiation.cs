using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomInstantiation : MonoBehaviour
{
    [SerializeField] private GameObject []arrayRoom = new GameObject[4];
    [SerializeField] private GameObject panel;

    /// <summary>
    /// This method used to instantiate room that player choose it
    /// </summary>
    /// <param name="index"></param>
    public void createRoom(int index)
    {
        panel.SetActive(false);
        Instantiate(arrayRoom[index], new Vector3(0, 0, 0), Quaternion.identity);

        GameManager.instance.calculateMoney(index);
    }
}
