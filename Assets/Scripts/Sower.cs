using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sower : MonoBehaviour
{

    [SerializeField] private CropsManagement _cropsManagement;
    [SerializeField] private Harvester _harvester;
    [SerializeField] private GameObject _carrotPrefab;
    [SerializeField] private GameObject _berriesPrefab;
    [SerializeField] private GameObject _wheatPrefab;

    public void SowCarrot()
    {
        _cropsManagement.Carrots(-1);
        // instantiate et récupérer le component harvester
        // lui attirubuer le bon prefab
        // lui attribuer la porte pour l'event
    }
    public void SowBerries()
    {
        _cropsManagement.Berries(-1);
    }
    public void SowWheat()
    {
        _cropsManagement.Wheat(-1);
    }

    public void Close()
    {
        Time.timeScale = 1;
    }
}
