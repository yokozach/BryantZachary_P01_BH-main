using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class To_Game : MonoBehaviour
{
    public void toGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Leave()
    {
        Application.Quit();
    }

}
