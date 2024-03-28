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

    public void Kill()
    {
        if (Random.Range(0, 3) == 0)
        {
            Destroy(GetComponent<Grower>());
            _SR.sprite = _infos.deadSprite;
            _interact.normalSprite = _infos.deadSprite;
            _interact.interactSprite = _infos.interactDeadSprite;
            _harvester.canHarvest = true;
            _harvester.isDead = true;
        }
    }

    private void OnDestroy()
    {
        Death.Instance.OnDeath -= Kill;
    }
}
