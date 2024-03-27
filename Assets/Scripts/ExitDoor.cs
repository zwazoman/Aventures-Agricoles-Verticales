using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ExitDoor : MonoBehaviour
{
    private bool _canInteract;
    public event Action OnExit;

    [SerializeField] private Interact _interact;

    private void Update()
    {
        _canInteract = _interact._canInteract;
    }

    public void Interact(InputAction.CallbackContext context)
    {
        if (context.performed && _canInteract) Exit();
    }

    private void Exit()
    {
        OnExit?.Invoke();
    }
}
