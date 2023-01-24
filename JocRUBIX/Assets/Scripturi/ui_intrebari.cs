using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui_intrebari : MonoBehaviour
{
    private bool ras_dat = false;
    private int raspuns_corect;
    private int raspuns_curent;
    // Start is called before the first frame update
    void Start()
    {
        // trebuie sa ii dai valoare la raspunsu corect
        // raspuns_corect = 
        raspuns_curent = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (ras_dat)
        {
           if(raspuns_corect == raspuns_curent)
            {
                //ARATA CORECT
            }
            else
            {
                // arata gresit
            }
        }
    }
    
}
