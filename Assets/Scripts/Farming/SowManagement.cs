using UnityEngine;

public class SowManagement : MonoBehaviour
{
    [SerializeField] private CropClass _infos;
    [SerializeField] private GameObject _shovel;

    /// <summary>
    /// Instantie la plante et prépare ses scripts pour la pousse et la récolte
    /// </summary>
    public void Sow()
    {
        GameObject crop = Instantiate(_infos.Prefab,_shovel.transform.position,Quaternion.identity);
        crop.GetComponent<Harvester>().Shovel = _shovel;
        crop.GetComponent<Harvester>().IsCarrot = _infos.IsCarrot;
        crop.GetComponent<Harvester>().IsBerries = _infos.IsBerries;
        crop.GetComponent<Harvester>().IsWheat = _infos.IsWheat;
        _shovel.SetActive(false);
        if (_infos.IsCarrot) CropsManagement.Instance.Carrots(-1);
        if (_infos.IsBerries) CropsManagement.Instance.Berries(-1);
        if (_infos.IsWheat) CropsManagement.Instance.Wheat(-1);
    }
}
