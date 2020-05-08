﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Planeta : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Planeta");
        }
    }
}
