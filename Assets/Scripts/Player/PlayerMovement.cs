using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Collider2D _coll2d;
    private Rigidbody2D _rb2d;

    private float _horizontal;

    [SerializeField] private float _speed = 8f;
    [SerializeField] private float _jumpPower = 16f;

    //public event Action OnJump;
    //public event Action OnLand;

    private void Awake()
    {

        _coll2d = GetComponent<Collider2D>();
        _rb2d = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        _rb2d.velocity = new Vector2 (_horizontal * _speed, _rb2d.velocity.y);
    }

    private bool IsGrounded()
    {
        RaycastHit2D[] hit2d = new RaycastHit2D[1];
        return _coll2d.Cast(Vector2.down, hit2d, 0.1f) > 0;
    }

    public void Move(InputAction.CallbackContext context)
    {
        _horizontal = context.ReadValue<Vector2>().x;
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            _rb2d.velocity = new Vector2(_rb2d.velocity.x,_jumpPower);
            //OnJump?.Invoke();
        }
        if (context.canceled && _rb2d.velocity.y > 0)
        {
            _rb2d.velocity = new Vector2(_rb2d.velocity.x, _rb2d.velocity.y * 0.5f);
        }
    }
}
