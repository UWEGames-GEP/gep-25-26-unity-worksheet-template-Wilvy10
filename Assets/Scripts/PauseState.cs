using UnityEngine;

public class PauseState : GameState
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //set state to pause
            //state = GameState.GAMEPLAY;
            //hasChangedState = true;
        }
    }
    public void OnEnter()
    {
        Time.timeScale = 0.0f;
    }
    public void OnExit()
    {
        Time.timeScale = 1.0f;
    }
}
