public class MenuSound : MonoBehaviour
{
    private AudioSource music;
    public AudioClip clickAudio;

    void Start()
    {

        music = GetComponent<AudioSource>();
    }


    public void ClickAudioOn()
    {
        music.PlayOneShot(clickAudio);
    }
}