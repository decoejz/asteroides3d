using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontoFinal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = "Você fez " + PlayerPrefs.GetInt("Pontos", 0) + " pontos";
    }
}
