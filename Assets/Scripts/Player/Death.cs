using System;
using UnityEngine;

public class Death : MonoBehaviour
{
    public static Death Instance;

    public event Action OnDeath;

    private Vector2 _initialPosition;

    private void Awake()
    {
        Instance = this; // singleton
        _initialPosition = transform.position;
    }

    /// <summary>
    /// gestion de la mort du joueur : mets tous les compteurs a zero, lance l'evennement "OnDeath" et le téléporte à son poitn de spawn
    /// </summary>
    public void Die()
    {
        OnDeath?.Invoke();
        AudioManager.Instance.PlaySFX(AudioManager.Instance.DieSound); // joue le son de mort
        transform.position = _initialPosition;
        CoinManagement.Instance.Coin(-CoinManagement.Instance.NbCoin); // reset l'argent
        CropsManagement.Instance.Carrots(-CropsManagement.Instance.NbCarrots); // reset les carottes
        CropsManagement.Instance.Berries(-CropsManagement.Instance.NbBerries); // reset les berries
        CropsManagement.Instance.Wheat(-CropsManagement.Instance.NbWheat); // reset le blé
    }
}
