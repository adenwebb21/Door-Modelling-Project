using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeToBlack : MonoBehaviour {

    public Image blackScreen;

    private void Start()
    {
        blackScreen.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        blackScreen.gameObject.SetActive(true);
        Invoke("LoadScene", 1f);
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(0);
        return;
    }
}
