using UnityEngine;

public class GameplayState : GameState
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

           
        }
    }
    public override void onEnter()
    {
        
    }
    public override void onExit()
    {

    }


}
