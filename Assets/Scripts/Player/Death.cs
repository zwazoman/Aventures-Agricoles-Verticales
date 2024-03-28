using System;
using UnityEngine;

public class Death : MonoBehaviour
{
    public static Death Instance;

    public event Action OnDeath;

    private Vector2 _initialPosition;

    private void Awake()
    {
        _initialPosition = transform.position;
        Instance = this; // singleton
    }

    public void Die()
    {
        OnDeath?.Invoke();
        transform.position = _initialPosition;
        CropsManagement.instance.Carrots(-CropsManagement.instance.nbCarrots);
        CropsManagement.instance.Berries(-CropsManagement.instance.nbBerries);
        CropsManagement.instance.Wheat(-CropsManagement.instance.nbWheat);
    }
}
