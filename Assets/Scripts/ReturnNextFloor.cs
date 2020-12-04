using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnNextFloor : MonoBehaviour
{
    public GameObject GameSaveManager;
    public GameObject loadScreen;
    public Slider slider;
    public Text text;
    private GameSaveManager manager;
    // Scene switching
    IEnumerator LoadLevel()
    {
        loadScreen.SetActive(true);

        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex - 1);
        operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            slider.value = operation.progress;
            text.text = operation.progress * 100 + "%";

            if (operation.progress >= 0.9f)
            {
                slider.value = 1;

                text.text = "Press Space to continue";

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    operation.allowSceneActivation = true;
                }
            }
            yield return null;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            manager = GameSaveManager.GetComponent<GameSaveManager>();
            manager.SaveGame();
            StartCoroutine(LoadLevel());
            manager.LoadGame();
        }
    }
}
