using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Collider2D _coll2d;
    private Rigidbody2D _rb2d;
    private float _horizontal;

    [SerializeField] private float _speed = 8f;
    [SerializeField] private float _jumpPower = 16f;

    private void Awake()
    {
        _coll2d = GetComponent<Collider2D>();
        _rb2d = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        _rb2d.velocity = new Vector2 (_horizontal * _speed, _rb2d.velocity.y);
    }
    
    /// <summary>
    /// vérifie si le joueur est au sol ou non 
    /// </summary>
    /// <returns></returns>
    private bool IsGrounded()
    {
        RaycastHit2D[] hit2d = new RaycastHit2D[1];
        return _coll2d.Cast(Vector2.down, hit2d, 0.1f) > 0;
    }

    /// <summary>
    /// déplacements du joueur avec l'input system
    /// </summary>
    /// <param name="context"></param>
    public void Move(InputAction.CallbackContext context)
    {
        _horizontal = context.ReadValue<Vector2>().x;
    }

    /// <summary>
    /// saut du joueur avec l'input system
    /// </summary>
    /// <param name="context"></param>
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
