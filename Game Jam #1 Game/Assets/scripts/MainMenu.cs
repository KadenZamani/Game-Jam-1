using UnityEngine;
using UnityEngine.SceneManagement;
public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void play()
    {
        SceneManager.LoadScene(1);

    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("Player has Quit");
    }
}
