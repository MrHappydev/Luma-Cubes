using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ziel : MonoBehaviour
{
    public Canvas bild;

    private void Start()
    {
        bild.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bild.enabled = true;
        Invoke("NextLevel", 2f);

    }

    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
