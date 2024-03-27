using UnityEngine;

public class Sower : MonoBehaviour
{
    // diviser en 5 scripts et utiliser scriptables

    [SerializeField] private GameObject _shovel;
    [SerializeField] private GameObject _carrotPrefab;
    [SerializeField] private GameObject _berriesPrefab;
    [SerializeField] private GameObject _wheatPrefab;

    public void SowCarrot()
    {
        CropsManagement.instance.Carrots(-1);
        GameObject _carrot = Instantiate(_carrotPrefab,_shovel.transform.position,Quaternion.identity);
        _carrot.GetComponent<Harvester>().shovel = _shovel;
        _carrot.GetComponent<Harvester>().isCarrot = true;
        _shovel.SetActive(false);
    }
    public void SowBerries()
    {
        CropsManagement.instance.Berries(-1);
        GameObject _berries = Instantiate(_berriesPrefab, _shovel.transform.position, Quaternion.identity);
        _berries.GetComponent<Harvester>().shovel = _shovel;
        _berries.GetComponent<Harvester>().isBerries = true;
        _shovel.SetActive(false);
    }
    public void SowWheat()
    {
        CropsManagement.instance.Wheat(-1);
        GameObject _wheat = Instantiate(_wheatPrefab, _shovel.transform.position, Quaternion.identity);
        _wheat.GetComponent<Harvester>().shovel = _shovel;
        _wheat.GetComponent<Harvester>().isWheat = true;
        _shovel.SetActive(false);
    }
}
