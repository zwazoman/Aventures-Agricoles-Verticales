using System;
using UnityEngine;

public class Death : MonoBehaviour
{
    public static Death Instance;

    public event Action OnDeath;

    [SerializeField] private DeathSound _deathSound;

    private Vector2 _initialPosition;

    private void Awake()
    {
        Instance = this; // singleton
        _initialPosition = transform.position;
    }

    /// <summary>
    /// gestion de la mort du joueur : mets les compteurs des "crops" a zero, lance l'evennement "OnDeath" et le téléporte à son poitn de spawn
    /// </summary>
    public void Die()
    {
        OnDeath?.Invoke();
        _deathSound.PlayDie(); // joue le son de mort
        transform.position = _initialPosition;
        CropsManagement.Instance.Carrots(-CropsManagement.Instance.NbCarrots); // reset les carottes
        CropsManagement.Instance.Berries(-CropsManagement.Instance.NbBerries); // reset les berries
        CropsManagement.Instance.Wheat(-CropsManagement.Instance.NbWheat); // reset le blé
    }
}
