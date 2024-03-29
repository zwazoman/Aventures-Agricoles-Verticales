using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance; 

    [Header("AudioSources")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Musics")]
    [Header("SFX")]
    public AudioClip DoorSound;
    public AudioClip SowSound;
    public AudioClip DieSound;
    public AudioClip CoinSound;
    public AudioClip ButtonHoverSound;
    public AudioClip ButtonPressedSound;
    public AudioClip BounceSound;
    public AudioClip HarvestSound;
    public AudioClip ShopSound;
    public AudioClip JumpSound;

    private void Awake()
    {
        Instance = this; // singleton
    }

    public void PlaySFX(AudioClip clip, float _volume = 1, float _pitch = 1)
    {
        SFXSource.volume = _volume;
        SFXSource.pitch = _pitch;
        SFXSource.PlayOneShot(clip);
    }

    //music credits : "Home" by Neutrin05
    //Sfx credits : pixabay / soundly
}
