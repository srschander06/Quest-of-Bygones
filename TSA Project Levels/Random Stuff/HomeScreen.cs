using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HomeScreen : MonoBehaviour
{
    public void GoHome()
    {
        SceneManager.LoadScene("Start Screen");
    }
}
