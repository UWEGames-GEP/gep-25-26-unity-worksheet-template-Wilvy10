using UnityEngine;

public abstract class GameState 
{
    protected bool has_changed_state = false;
    protected GameState next_state = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public virtual void start()
    {
        
    }

    // Update is called once per frame
    public virtual void update()
    {
        
    }

    public virtual void onEnter()
    {

    }
    public virtual void onExit()
    {

    }
    public bool getHasChangedState()
    {
        return has_changed_state;
    }
    public void setHasChangedState(bool state_)
    {
        has_changed_state=state_;
    }
}
