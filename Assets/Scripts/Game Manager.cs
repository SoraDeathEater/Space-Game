using UnityEngine;
using UnityEngine.SceneManagement; // Need this for ResetGame, this lets us mess with the scenes.

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverMenu;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameOverMenu.SetActive(true);
        }
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(0); // You can see the scene number on the Build Preferences
    }
}
