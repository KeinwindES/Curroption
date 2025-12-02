using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class Quit : MonoBehaviour
{
    // Update is called once per frame
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
