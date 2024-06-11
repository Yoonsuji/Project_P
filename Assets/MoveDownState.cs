using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownState : ICharacterState
{
    public void HandleInput(PlayerMovement player)
    {
        if (Input.GetAxisRaw("Vertical") == 0)
        {
            player.SetState(new IdleState());
        }
    }

    public void Update(PlayerMovement player)
    {
        player.Move(Vector2.down);
        player.SetAnimation("Vertical", -1f);
    }
}
