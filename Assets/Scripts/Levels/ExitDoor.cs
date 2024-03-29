using System;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    [field :SerializeField] public GameObject Player { get; private set; }
    public event Action OnExit;

    [SerializeField] private Interact _interact;
    [SerializeField] private LvlSelection _lvlSelection;

    private void Start()
    {
        _interact.OnInteract += Exit;
    }

    /// <summary>
    /// invoke l'event "OnExit" qui sera écouté par les plantes et les scripts de sélection de niveaux
    /// </summary>
    private void Exit()
    {
        OnExit?.Invoke();
        AudioManager.Instance.PlaySFX(AudioManager.Instance.DoorSound); // joue le son de porte
    }
}
