using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextureScroller ground;
    public float totalTimeInStage = 10;
    float timeElapsed = 0;
    float gameTime = 0;
    bool isGameOver = false;

    void Update()
    {
        if (isGameOver)
            return;

        totalTimeInStage += Time.deltaTime;
        gameTime += Time.deltaTime;

        if (gameTime > totalTimeInStage)
        {
            isGameOver = true;
            ground.speed = 0;
        }
    }

    public void AdjustTime(float amount)
    {
        gameTime += amount;
        if (amount < 0)
            SlowWorldDown();
    }

    void SlowWorldDown()
    {
        // Cancel any invokes to speed the world up
        // then slow the world down for 1 second
        CancelInvoke();
        Time.timeScale = 0.5f;
        Invoke("SpeedWorldUp", 1);
    }

    void SpeedWorldUp()
    {
        Time.timeScale = 1f;
    }

    // Note this is using Unity’s legacy GUI system
    void OnGUI()
    {
        if (isGameOver)
        {
            Rect boxRect = new Rect(Screen.width / 2 - 60, Screen.height / 2 - 100, 120, 50);
            Rect labelRect = new Rect(Screen.width / 2 - 55, Screen.height / 2 - 90, 100, 40);
            GUI.Box(boxRect, "Game Over");
            GUI.Label(labelRect, "Total Time: " + totalTimeInStage);
            Time.timeScale = 0;
        }
        else
        {
            Rect boxRect = new Rect(Screen.width / 2 - 50, Screen.height - 100, 100, 50);
            Rect labelRect = new Rect(Screen.width / 2 - 40, Screen.height - 90, 80, 40);
            GUI.Box(boxRect, "Time Remaining");
            GUI.Label(labelRect, ((int)(totalTimeInStage - gameTime)).ToString());
        }
    }
}