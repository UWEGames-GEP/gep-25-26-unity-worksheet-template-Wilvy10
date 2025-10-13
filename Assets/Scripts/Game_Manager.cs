using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    private bool hasChangedState = false;
    private PauseState pause = new PauseState();
    private GameplayState gameplay = new GameplayState();
    [SerializeField] GameState current_state;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("started project");
        current_state = gameplay;
    }

    // Update is called once per frame
    void Update()
    {
        current_state.update();

    }
    private void LateUpdate()
    {
        if (current_state.getHasChangedState())
        {
            //sloppy way of checking what state should be next
            if (current_state == gameplay) 
            {
                setState(pause);
            }else
            {
                setState(gameplay);
            }
            current_state.setHasChangedState(false);
        }
      
    }

    public void setState(GameState state)
    {
        Debug.Log(state.ToString());
        current_state.onExit();
        current_state = state;
        current_state.onEnter();
    }
}
