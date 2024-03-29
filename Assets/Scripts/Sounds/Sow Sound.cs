using UnityEngine;

public class SowSound : MonoBehaviour
{
    public void PlaySow()
    {
        AudioManager.Instance.PlaySFX(AudioManager.Instance.SowSound);
    }
}
