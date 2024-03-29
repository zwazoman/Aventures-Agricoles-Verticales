using UnityEngine;

public class HarvestSound : MonoBehaviour
{
    public void PlayHarvest()
    {
        AudioManager.Instance.PlaySFX(AudioManager.Instance.HarvestSound);
    }
}
