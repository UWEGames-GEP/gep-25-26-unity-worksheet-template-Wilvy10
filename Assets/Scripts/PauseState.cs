using System;
using UnityEngine;

public class PauseState : GameState
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void start()
    {
        
    }

    // Update is called once per frame
    public override void update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            has_changed_state = true;
            //next_state = GameplayState s
           
        }
    }
    public override void onEnter()
    {
        Time.timeScale = 0.0f;
        Debug.Log("paused");
    }
    public override void onExit()
    {
        Time.timeScale = 1.0f;
        Debug.Log("not paused");
    }
}
