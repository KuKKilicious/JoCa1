using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager> {
    private int score;
    public float timelimit;
    public UnityEngine.UI.Text ScoreDisplay;
    public UnityEngine.UI.Text TimeDisplay;
    public UnityEngine.UI.Text GameOverText;
    public GameObject player;
    private bool timestopped;
    protected GameManager() { }
    // Use this for initialization
    void Start () {
        ScoreDisplay.text = "0";
        TimeDisplay.text = "" + timelimit;
    }
	
	// Update is called once per frame
	void Update () {
        if (!timestopped)
        {
            timelimit -= Time.deltaTime;
        }
        int a = (int)timelimit;


        TimeDisplay.text = a.ToString();

        if (timelimit < 0)
        {
            GameOver("Time is up");
        }
    }

    public void GameOver(string message)
    {
        Debug.Log("GameOver");
        GameOverText.text = message;
        GameOverText.enabled = true;
        Destroy(player);
        stopTime();

    }
    private void stopTime()
    {
        timestopped = true;
    }
}
