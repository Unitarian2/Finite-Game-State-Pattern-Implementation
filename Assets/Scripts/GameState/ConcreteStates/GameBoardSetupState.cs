using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoardSetupState : GameBaseState
{
    public override void EnterState(GameStateManager stateManager)
    {
        Debug.LogWarning("Board Setup State");
        GameManager.Instance.SetupBoard();
    }

    public override void UpdateState(GameStateManager stateManager)
    {
        
    }
}
