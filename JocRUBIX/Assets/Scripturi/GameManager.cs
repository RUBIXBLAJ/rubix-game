using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEditor.PackageManager;

public class GameManager : MonoBehaviour
{
    Intrebari[] intrebari= null;
    public Intrebari[] Intrebari { get { return intrebari; } }

    [SerializeField] MeniuJoc joc = null;

    private List<DataRaspunsuri> raspunsuriList = null;

    private List<int> intrebariTerminate = new List<int>();

    private int intrebareCurenta = 0;

    private void Start()
    {
        IncarcaIntrebari();

        foreach (var intrebare in intrebari)
        {
            Debug.Log(intrebare.Intrebare);
        }

       // Display();
    }



    public void StergeRas()
    {
        raspunsuriList = new List<DataRaspunsuri>();
    }


    void Display()
    {
        StergeRas();
        var question = IntrebareRandom();
        if(joc.UpdateQuestionUI != null)
        {
            joc.UpdateQuestionUI(question);
        }
        else
        {
            Debug.Log("Eroare! Nu mai sunt intrebari");
        }
    }
     
    Intrebari IntrebareRandom()
    {
        var randomIndex = IndexRandomIntreb();
        intrebareCurenta = randomIndex; 

        return Intrebari[intrebareCurenta];
    }

    int IndexRandomIntreb()
    {
        var random = 0;
        if(intrebariTerminate.Count < Intrebari.Length)
        {
            do
            {
                random = Random.Range(0, Intrebari.Length);
            } while (intrebariTerminate.Contains(random) || random == intrebareCurenta);
        }
        return random;
    }

    void IncarcaIntrebari()
    {
        Object[] objs = Resources.LoadAll("Intrebari", typeof(Intrebari));
        intrebari = new Intrebari[objs.Length];
        
        for(int i = 0;i< objs.Length;i++) 
        {
            intrebari[i] = (Intrebari)objs[i];
        }

    }
}

