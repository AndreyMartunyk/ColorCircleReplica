using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("WinScene", LoadSceneMode.Single);
    }
}
