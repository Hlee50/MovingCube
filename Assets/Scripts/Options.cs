using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public AudioMixer audioMixer;

    void Start()
    {
        FindObjectOfType<Slider>().value = PlayerPrefs.GetFloat("Vslider");
    }
    public void BacktoMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        PlayerPrefs.SetFloat("Vslider", volume);
    }
}
