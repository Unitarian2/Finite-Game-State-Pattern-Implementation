using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayerTurnState : GameBaseState
{
    public override void EnterState(GameStateManager stateManager)
    {
        Debug.LogWarning("Player Turn State");
        InputManager.Instance.SetIsPlayerTurn(true);
    }

    public override void UpdateState(GameStateManager stateManager)
    {
        
    }
}
