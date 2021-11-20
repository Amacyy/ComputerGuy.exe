using UnityEngine;

public class mainmenu : MonoBehaviour
{

    void start()
    {


    }

    void update()
    {

    }

    public void Play()
    {
        Application.LoadLevel("GameDevSolo");
    }

    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 1;
        }
    }
}