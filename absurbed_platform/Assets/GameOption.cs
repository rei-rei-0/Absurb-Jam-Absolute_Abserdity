using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOption : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        //restarts the game but possibly lighting might be affected
        //issue is only in the editor, should be fine if exported or compile

        if (Input.GetKey("escape"))
        {
            Debug.Log("quit");
            Application.Quit();//doesn't work in the editor
        }//quits the games with esc key
    }
}