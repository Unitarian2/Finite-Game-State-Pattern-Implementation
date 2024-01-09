using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public GameBaseState currentState;

    public GamePlayerTurnState PlayerTurnState = new();
    public GameTransitionState TransitionState = new();
    public GameBoardSetupState BoardSetupState = new();

    // Start is called before the first frame update
    void Start()
    {
        currentState = TransitionState;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(GameBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
