using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ui_Main : MonoBehaviour
{
  
    public GameObject Raspunsuri;
    public Slider timp;
    public static bool raspuns;
    public int scor;
    public bool ras = false;
    public GameObject ras_bun;
    public GameObject ras_rau;
    
    // Start is called before the first frame update
    void Start()
    {
        
        Raspunsuri.SetActive(true);
        scor = 0;
        ras_bun.SetActive(false);
        ras_rau.SetActive(false);
        timp.SetEnabled(true);
        raspuns = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
