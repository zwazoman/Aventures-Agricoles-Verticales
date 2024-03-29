using UnityEngine;

public class Harvester : MonoBehaviour
{
    public bool CanHarvest { get; set; }
    public GameObject Shovel { get; set; }
    public bool IsCarrot { get; set; }
    public bool IsBerries { get; set; }
    public bool IsWheat { get; set; }
    public bool IsDead { get; set; }

    [SerializeField] private Interact _interact;
    [SerializeField] private CropClass _infos;

    private void Start()
    {
        _interact.OnInteract += Harvest;   
    }

    /// <summary>
    /// vérifie et gère la récolte des plantes par le joueur
    /// </summary>
    private void Harvest() // switchcase
    {
        if (!CanHarvest) return;
        AudioManager.Instance.PlaySFX(AudioManager.Instance.HarvestSound); // joue le son de récolte
        if (!IsDead)
        {
            if (IsCarrot) CropsManagement.Instance.Carrots(_infos.drops);
            if (IsBerries) CropsManagement.Instance.Berries(_infos.drops); 
            if (IsWheat) CropsManagement.Instance.Wheat(_infos.drops);
        }
        Shovel.SetActive(true);
        Destroy(gameObject);
    }
}
