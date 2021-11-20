using UnityEngine;

public class restart : MonoBehaviour
{

    void start()
    {


    }

    void update()
    {

    }

    public void Play()
    {
        Application.LoadLevel("GameDevSolo 2");
    }

    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 1;
        }
    }
}