using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(MazeConstructor))]

public class GameController : MonoBehaviour
{

    public static int MazeBlockx = 27;
    public static int MazeBlockz = 31;

    //1
    [SerializeField] private FpsMovement player;
    [SerializeField] private Text timeLabel;
    [SerializeField] private Text scoreLabel;

    private MazeConstructor generator;

    //2
    private DateTime startTime;
    private int timeLimit;
    private int reduceLimitBy;
    private int Mazex;
    private int Mazez;

    private int score;
    private bool goalReached;

    //3
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<FpsMovement>();
        generator = GetComponent<MazeConstructor>();
        StartNewGame();
    }

    //4
    private void StartNewGame()
    {
        timeLimit = 80;
        reduceLimitBy = 5;
        startTime = DateTime.Now;

        score = 0;
        //scoreLabel.text = score.ToString();

        StartNewMaze();
    }

    //5
    private void StartNewMaze()
    {
        Mazex = GameController.MazeBlockx;
        Mazez = GameController.MazeBlockz;
        generator.GenerateNewMaze(Mazex, Mazez, OnStartTrigger, OnGoalTrigger);

        float x = generator.startCol * generator.hallWidth;
        float y = 1;
        float z = generator.startRow * generator.hallWidth;
        player.transform.position = new Vector3(x, y, z);

        goalReached = false;
        player.enabled = true;

        // restart timer
        timeLimit -= reduceLimitBy;
        startTime = DateTime.Now;
    }

    //6
    void Update()
    {
        if (!player.enabled)
        {
            return;
        }

        int timeUsed = (int)(DateTime.Now - startTime).TotalSeconds;
        int timeLeft = timeLimit - timeUsed;

        if (timeLeft > 0)
        {
            //timeLabel.text = timeLeft.ToString();
        }
        else
        {
            //timeLabel.text = "TIME UP";
            player.enabled = false;

            Invoke("StartNewGame", 4);
        }
    }

    //7
    private void OnGoalTrigger(GameObject trigger, GameObject other)
    {
        Debug.Log("Goal!");
        goalReached = true;

        score += 1;
        //scoreLabel.text = score.ToString();

        Destroy(trigger);
    }

    private void OnStartTrigger(GameObject trigger, GameObject other)
    {
        if (goalReached)
        {
            Debug.Log("Finish!");
            player.enabled = false;

            Invoke("StartNewMaze", 4);
        }
    }
}
