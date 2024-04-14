using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private IPlayerInputHandler _inputHandler;

    [SerializeField] private KeyCode _moveRightKey;
    [SerializeField] private KeyCode _moveLeftKey;
    [SerializeField] private KeyCode _jumpKey;

    private void Start() => _inputHandler = new PlayerInputHandler(_moveRightKey, _moveLeftKey, _jumpKey, GetComponent<Player>());
    private void Update() => _inputHandler.HandleInput();
}
