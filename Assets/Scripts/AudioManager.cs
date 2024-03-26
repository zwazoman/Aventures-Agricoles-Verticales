using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance = null;
    public static AudioManager Instance => _instance;

    [Header("AudioSources")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    [SerializeField] AudioSource SFXSource2;
    public int test = 10;

    [Header("Musics")]
    public AudioClip music;
    [Header("SFX")]
    public AudioClip SFX;



    private void Awake()
    {
        // Singleton
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            _instance = this;
            this.transform.SetParent(null);
        }
    }

    public void PlaySFX(AudioClip clip, float _volume, float _pitch)
    {
        SFXSource.volume = _volume;
        SFXSource.pitch = _pitch;
        SFXSource.PlayOneShot(clip);
    }
}
