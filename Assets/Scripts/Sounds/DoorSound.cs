using UnityEngine;

public class DoorSound : MonoBehaviour
{
    public void PlayDoor()
    {
        AudioManager.Instance.PlaySFX(AudioManager.Instance.DoorSound);
    }
}
