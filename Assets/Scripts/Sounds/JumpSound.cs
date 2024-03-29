using UnityEngine;

public class JumpSound : MonoBehaviour
{
    public void PlayJump()
    {
        AudioManager.Instance.PlaySFX(AudioManager.Instance.JumpSound, 0.8f, Random.Range(0.8f, 1.2f));
    }
}
