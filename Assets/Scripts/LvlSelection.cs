using System.Collections.Generic;
using UnityEngine;

public class LvlSelection : MonoBehaviour
{
    [SerializeField] private ExitDoor _exitDoor;
    [SerializeField] private List<GameObject> _spawnPointList = new List<GameObject>();

    private void Start()
    {
        _exitDoor.OnExit += ChangeLvl;
    }

    /// <summary>
    /// "sélectionne" un niveau et téléporte le joueur a ce dernier
    /// </summary>
    private void ChangeLvl()
    {
        GameObject selectedSpawnPoint = _spawnPointList[Random.Range(0, _spawnPointList.Count)];
        _exitDoor.Player.transform.position = selectedSpawnPoint.transform.position;
        selectedSpawnPoint.GetComponent<LvlEnabled>().ActiveCoins();
    }
}
