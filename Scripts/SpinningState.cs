using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningState : PlayerState
{
    public void Enter(Player player)
    {
        player.mCurrentState = new SpinningState();
        player.transform.Rotate(Vector3.up * 500000 * Time.deltaTime);
        Debug.Log("Enter Spinning State");
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyUp(KeyCode.U))
        {
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }
    }
}
