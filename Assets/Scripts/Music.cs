using UnityEngine;

public class Music : MonoBehaviour
{
    public static bool musicOn = true;
    private static Music instance = null;

/*    public static Music Instance
    {
        get { return instance; }
    }*/

    void Awake()
    {
        if (instance != null) //&& instance != this, for checking different music tracks 
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
        musicOn = true;
    }
    public void StopMusic()
    {
        if (musicOn)
        {
            Destroy(this.gameObject);
            musicOn = false;
        }
    }
}
