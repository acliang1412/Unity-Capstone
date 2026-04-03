using UnityEngine;

public class MenuControls : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("The game has closed.");
    }
}