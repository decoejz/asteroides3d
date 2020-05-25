using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPage : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("Pontos", 0);
        PlayerPrefs.SetInt("Vidas", 3);
    }

    public void Iniciar()
    {
        SceneManager.LoadScene("Espaco");
    }
}
