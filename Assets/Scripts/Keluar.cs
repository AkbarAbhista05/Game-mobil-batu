using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Keluar : MonoBehaviour
{


    public void KeluarDariGame()
    {
        Application.Quit();
        Debug.Log("Keluar");

    }
}
