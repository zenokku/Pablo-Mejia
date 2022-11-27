
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public bool desactivarEnInicio;
    public GameObject PLAY;
    bool pause;
    public void boton()
    {
        Time.timeScale = 1;
    }
    public void Escena()
    {
        SceneManager.LoadScene(1); 
    }
    public void Scene()
    {
        SceneManager.LoadScene(0);
    }
    void Start()
    {
        if (desactivarEnInicio) { 
        PLAY.SetActive(false);
        pause = false;
        Time.timeScale = 1;
    }
    }

    void Update()
    {
        if (PLAY.activeSelf && Input.GetKeyDown(KeyCode.P))
        {
            PLAY.SetActive(false);
        } 
        else if (!PLAY.activeSelf && Input.GetKeyDown(KeyCode.P))
        {
            PLAY.SetActive(true);
        }
        if (Input.GetKeyDown (KeyCode.P))
        {
            pause = ! pause ;
            PLAY.SetActive(pause);
            if (pause)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }
}
