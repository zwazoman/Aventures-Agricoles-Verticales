using UnityEngine;

public class BackToFarm : MonoBehaviour
{
    [SerializeField] private GameObject _farmSpawn;
    [SerializeField] private ExitDoor _exitDoor;

    private void Start()
    {
        _exitDoor.OnExit += GoBack;
    }

    /// <summary>
    /// téléporte le joueur au spawnPoint de la ferme
    /// </summary>
    private void GoBack()
    {
        _exitDoor.Player.transform.position = _farmSpawn.transform.position; 
    }

}
