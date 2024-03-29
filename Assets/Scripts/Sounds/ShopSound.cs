using UnityEngine;

public class ShopSound : MonoBehaviour
{
    public void PlayShop()
    {
        AudioManager.Instance.PlaySFX(AudioManager.Instance.ShopSound);
    }
}
