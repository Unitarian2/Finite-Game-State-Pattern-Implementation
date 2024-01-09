using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTransitionState : GameBaseState
{
    public override void EnterState(GameStateManager stateManager)
    {
        Debug.LogWarning("Transition State");
        InputManager.Instance.SetIsPlayerTurn(false);
    }

    public override void UpdateState(GameStateManager stateManager)
    {
        
    }
}
