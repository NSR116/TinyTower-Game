using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI moneyText;
    [SerializeField] private TextMeshProUGUI happinessText;
    [SerializeField] private TextMeshProUGUI goalText;
    [SerializeField] private TextMeshProUGUI currentText;

    private float goal = 400f;
    private float money = 500f;
    private float currentM = 0;
    private float happines = 0;

    private float timer = 40f;
    private Dictionary<int, float> mapRoom = new Dictionary<int, float>();

    public static GameManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        mapRoom.Add(0, 90f);
        mapRoom.Add(1, 150f);
        mapRoom.Add(2, 250f);
        mapRoom.Add(3, 50f);

        moneyText.text = money.ToString() + "$";
        happinessText.text = happines.ToString();
        currentText.text = currentM.ToString() + "$";
        goalText.text = goal.ToString()+"$";

        currentText.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        calculateHappiness();

        if(timer <= 0)
        {
            currentM = 0;
            currentText.text = currentM.ToString() + "$";

            timer = 40;
        }

    }

    /// <summary>
    /// This method used to calculate money of player when create a room
    /// and current money to check if the player reach goal then change the color of text
    /// </summary>
    /// <param name="index"></param>
    public void calculateMoney(int index)
    {
        float price = mapRoom[index];
        money = money - price;
        currentM = currentM + price;

        moneyText.text = money.ToString() + "$";
        currentText.text = currentM.ToString() + "$";

        if(currentM < goal)
        {
            currentText.color = Color.red;
        }

        else
        {
            currentText.color = Color.green;
        }

    }

    /// <summary>
    /// This method used to calculate happiness based on the timer and current money of player
    /// </summary>
    void calculateHappiness()
    {
        if(timer > 0 && currentM >= goal)
        {
            happines = happines + 50;
            happinessText.text = happines.ToString();

            if (currentM == goal)
            {
                money = money + 2000;
            }
            else
            {
                money = money + 2500;
            }

            moneyText.text = money.ToString() + "$";
            currentM = 0;
        }

        else if(timer <= 0)
        {
            if(happines == 0)
            {
                happines = 0;
            }
            else
            {
                happines = happines - 15;
            }

            happinessText.text = happines.ToString();
            currentM = 0;
        }
    }
}
