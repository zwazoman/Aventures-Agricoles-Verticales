using UnityEngine;

public class KillCrop : MonoBehaviour
{
    private SpriteRenderer _SR;

    [SerializeField] private CropClass _infos;
    [SerializeField] private Interact _interact;
    [SerializeField] private Harvester _harvester;
    void Start()
    {
        _SR = GetComponent<SpriteRenderer>();
        Death.Instance.OnDeath += Kill;
    }

    /// <summary>
    /// 1 chance sur 2 que la plante meure si le joueur meure
    /// </summary>
    public void Kill()
    {
        if (Random.Range(0, 2) == 0)
        {
            Destroy(GetComponent<Grower>());
            _SR.sprite = _infos.deadSprite;
            _interact.normalSprite = _infos.deadSprite;
            _interact.interactSprite = _infos.interactDeadSprite;
            _harvester.CanHarvest = true;
            _harvester.IsDead = true;
        }
    }

    private void OnDestroy()
    {
        Death.Instance.OnDeath -= Kill;
    }
}
