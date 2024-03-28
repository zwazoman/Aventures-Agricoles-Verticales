using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ExitDoor : MonoBehaviour
{
    [field :SerializeField] public GameObject Player { get; private set; }
    public event Action OnExit;

    [SerializeField] private Interact _interact;
    [SerializeField] private LvlSelection _lvlSelection;
    private bool _canInteract;
    private void Update()
    {
        _canInteract = _interact._canInteract;
    }

    /// <summary>
    /// Input system : interaction (e)
    /// </summary>
    /// <param name="context"></param>
    public void Interact(InputAction.CallbackContext context)
    {
        if (context.performed && _canInteract) Exit();
    }

    /// <summary>
    /// invoke l'event "OnExit" qui sera écouté par les plantes et les scripts de sélection de niveaux
    /// </summary>
    private void Exit()
    {
        OnExit?.Invoke();
    }
}
