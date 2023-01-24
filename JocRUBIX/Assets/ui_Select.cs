using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui_Select : MonoBehaviour
{
    public GameObject infoPanel;
    // Start is called before the first frame update
    void Start()
    {
        infoPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void elev()
    {
        SceneManager.LoadScene("Quiz_Elev");
    }

    public void profesor()
    {
        SceneManager.LoadScene("QuizCreate");
    }
    public void info()
    {
        infoPanel.SetActive(true);
    }
}
