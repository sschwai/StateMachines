using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public string GameScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        { Quit(); }
    }

    void Quit()
    {
        Debug.Log("Escape key pressed");
        //Application.Quit();
        SceneManager.LoadScene(GameScene);
    }
}
