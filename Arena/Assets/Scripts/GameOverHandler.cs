using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameOverHandler : MonoBehaviour
{
    public void Restart()
    {
        ArenaUIHandler.AUIHandler.gameOverPanel.SetActive(false);
        GameManager.Instance.WaveCount = 0;
        SceneManager.LoadScene(1);
        //PlayerCharacter.FindObjectOfType<PlayerCharacter>().IsGameOver = false;
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
