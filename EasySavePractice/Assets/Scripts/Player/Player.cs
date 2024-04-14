using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _speed;
    [SerializeField] private float _groundCheckRadius;

    private Rigidbody2D _rigidbody;

    private bool _isGrounded;
    private bool _canJump;

    private void Start() 
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _canJump = true;
        _isGrounded = true;
    } 
    private void Update() => CheckGround();

    public void MoveRight() => transform.Translate(Vector2.right * _speed * Time.deltaTime);
    public void MoveLeft() => transform.Translate(Vector2.left * _speed * Time.deltaTime);
    public void Jump()
    {
        _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        _canJump = false;
    }

    public bool CanJump() => _canJump && _isGrounded;
    private void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, _groundCheckRadius);
        _isGrounded = colliders.Length > 1;

        if (_isGrounded)
            _canJump = true;
    }
}
