using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : IPlayerInputHandler
{
    private readonly KeyCode _moveRightKey;
    private readonly KeyCode _moveLeftKey;
    private readonly KeyCode _jumpKey;

    private readonly Player _player;

	public PlayerInputHandler(KeyCode moveRightKey, KeyCode moveLeftKey, KeyCode jumpKey, Player player)
	{
		_moveRightKey = moveRightKey;
		_moveLeftKey = moveLeftKey;
		_jumpKey = jumpKey;
		_player = player;
	}
    public void HandleInput()
    {
        if (Input.GetKey(_moveRightKey))
            _player.MoveRight();
     
        else if (Input.GetKey(_moveLeftKey))
            _player.MoveLeft();
       
        if (Input.GetKeyDown(_jumpKey) && _player.CanJump())
            _player.Jump();
    }
}
