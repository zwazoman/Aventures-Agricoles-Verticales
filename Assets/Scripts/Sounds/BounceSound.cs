using UnityEngine;

public class BounceSound : MonoBehaviour
{
    public void PlayBounce()
    {
        AudioManager.Instance.PlaySFX(AudioManager.Instance.BounceSound);
    }
}
