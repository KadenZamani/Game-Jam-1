using UnityEngine;
using UnityEngine.SceneManagement;
public class backButton : MonoBehaviour
{
   public void back()
    {
        SceneManager.LoadScene(0);
    }

}
