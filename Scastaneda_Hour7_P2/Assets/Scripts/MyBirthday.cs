using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    void Start()
    {
        int birthdayDay = 1; // Your birthday day
        int daysInMonth = 31; // October has 31 days

        for (int day = 1; day <= daysInMonth; day++)
        {
            if (day == birthdayDay)
            {
                Debug.Log("It's my birthday!");
            }
            else
            {
                Debug.Log(day);
            }
        }
    }