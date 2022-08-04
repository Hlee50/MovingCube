using UnityEngine;

public class StopMusic : MonoBehaviour
{
    void Start()
    {
        if (Music.musicOn)
        {
           GameObject.FindGameObjectWithTag("Music").GetComponent<Music>().StopMusic();
        }
    }
}
