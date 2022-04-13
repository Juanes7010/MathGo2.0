using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenLevel : MonoBehaviour
{
    public string NameScene;
    public void Openlevel()
    {
        SceneManager.LoadScene(NameScene);
    }
}
