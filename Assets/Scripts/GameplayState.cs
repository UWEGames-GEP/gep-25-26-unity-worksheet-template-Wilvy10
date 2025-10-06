using UnityEngine;

public class GameplayState : GameState
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
            //state = GameState.PAUSE;
            //hasChangedState = true;
        }
    }
    public void OnEnter()
    {
        
    }
    public void OnExit()
    {

    }
}
