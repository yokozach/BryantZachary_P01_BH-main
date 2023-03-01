using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_state_machine : MonoBehaviour
{

    private bool _changed= false;


    public enum State
    {

        Gameplay, Win, Loose, quit,
    }

    public State _states;


    public void FixedUpdate()
    {
        if (_changed == true)
        {
            switch (_states)
            {


                case State.Gameplay:
                    SceneManager.LoadScene(1);
                    _changed = false;
                    break;
                case State.Win:
                    SceneManager.LoadScene(3);
                    _changed = false;
                    break;
                case State.Loose:
                    Debug.Log("loose");
                    SceneManager.LoadScene(2);
                    _changed = false;
                    break;
                case State.quit:
                    Application.Quit();
                    _changed = false;
                    break;
               

            }

        }
    }

    public void Game()
    {
       
        _states = State.Gameplay;
        _changed = true;
    }

    public void looser()
    {
        _states = State.Loose;

        _changed = true;
    }

    public void winner()
    {
        _states = State.Win;
        _changed = true;

    }
    public void leave()
    {
       
        _states = State.quit;
        _changed = true;
    }

   

}
