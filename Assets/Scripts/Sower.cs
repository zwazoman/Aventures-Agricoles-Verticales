using UnityEngine;

public class Sower : MonoBehaviour
{
    // diviser en 4 scripts et utiliser scriptables

    [HideInInspector] public CropsManagement _cropsManagement;
    [SerializeField] private GameObject _shovel;
    [SerializeField] private GameObject _carrotPrefab;
    [SerializeField] private GameObject _berriesPrefab;
    [SerializeField] private GameObject _wheatPrefab;

    public void SowCarrot()
    {
        _cropsManagement.Carrots(-1);
        GameObject _carrot = Instantiate(_carrotPrefab,_shovel.transform.position,Quaternion.identity);
        _carrot.GetComponent<Harvester>().shovel = _shovel;
        _carrot.GetComponent<Harvester>().isCarrot = true;
        _carrot.GetComponent<Harvester>().cropManagement = _cropsManagement;
        _carrot.GetComponent<Grower>().growDoor = _cropsManagement.growDoor;
        _shovel.SetActive(false);
    }
    public void SowBerries()
    {
        _cropsManagement.Berries(-1);
        GameObject _berries = Instantiate(_berriesPrefab, _shovel.transform.position, Quaternion.identity);
        _berries.GetComponent<Harvester>().shovel = _shovel;
        _berries.GetComponent<Harvester>().isBerries = true;
        _berries.GetComponent<Harvester>().cropManagement = _cropsManagement;
        _berries.GetComponent<Grower>().growDoor = _cropsManagement.growDoor;
        _shovel.SetActive(false);
    }
    public void SowWheat()
    {
        _cropsManagement.Wheat(-1);
        GameObject _wheat = Instantiate(_wheatPrefab, _shovel.transform.position, Quaternion.identity);
        _wheat.GetComponent<Harvester>().shovel = _shovel;
        _wheat.GetComponent<Harvester>().isWheat = true;
        _wheat.GetComponent<Harvester>().cropManagement = _cropsManagement;
        _wheat.GetComponent<Grower>().growDoor = _cropsManagement.growDoor;
        _shovel.SetActive(false);
    }

    public void Close()
    {
        Time.timeScale = 1;
    }
}
