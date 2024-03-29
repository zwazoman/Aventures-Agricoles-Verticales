using UnityEngine;

public class DeathSound : MonoBehaviour
{
    public void PlayDie()
    {
        AudioManager.Instance.PlaySFX(AudioManager.Instance.DieSound);
    }
}
