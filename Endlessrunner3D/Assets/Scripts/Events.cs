using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
   public void ReplayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ApplicationQuit()
    {
        
        SceneManager.LoadScene("MainMenu");


    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");

    }
}
