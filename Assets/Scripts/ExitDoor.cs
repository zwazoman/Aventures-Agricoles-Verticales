using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ExitDoor : MonoBehaviour
{
    private bool _canInteract;
    public event Action OnExit;
    private SpriteRenderer _SR;
    [SerializeField] private Sprite _interactSprite;
    private Sprite _normalSprite;

    private void Awake()
    {
        _SR = GetComponent<SpriteRenderer>();
        _normalSprite = _SR.sprite;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _canInteract = true;
        //_SR.sprite = _interactSprite;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _canInteract = false;
        //_SR.sprite = _normalSprite;
    }

    public void Interact(InputAction.CallbackContext context)
    {
        if (context.performed && _canInteract)
        {
            Exit();
        }
    }

    private void Exit()
    {
        OnExit?.Invoke();
        print("exit");
    }
}
