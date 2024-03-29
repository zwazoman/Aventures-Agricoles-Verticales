using UnityEngine;

public class CoinSound : MonoBehaviour
{
    public void PlayCoin()
    {
        AudioManager.Instance.PlaySFX(AudioManager.Instance.CoinSound);
    }
}
