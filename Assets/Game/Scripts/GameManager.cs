using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using SS.View;

public class GameManager : Controller
{
    [SerializeField] private float timeRemaining = 60;
    [SerializeField] private TMP_Text timeText;

    [HideInInspector]
    public static GameManager instance;

    public string state = "PLAY";

    private void Awake()
    {
        instance = this;
    }

    public void Ending(bool win)
    {
        state = "END";
        timeText.text = "LOSE";
        if (win) { timeText.text = "WIN"; }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject)
            {
                Debug.Log(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            }
            else
            {
                if(state == "PLAY")
                {
                    Manager.Add(ResultController.RESULT_SCENE_NAME);
                    state = "END";
                }
            }
        }
        if(state == "PLAY")
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        if(timeText)
        {
            timeToDisplay += 1;
            float minutes = Mathf.FloorToInt(timeToDisplay / 60);
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);
            timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    public override string SceneName()
    {
        return "Game";
    }

    public void PauseClick()
    {
        state = "PAUSE";
        Manager.Add(PauseController.PAUSE_SCENE_NAME);
    }
}
