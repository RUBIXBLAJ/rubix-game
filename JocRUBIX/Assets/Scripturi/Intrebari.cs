using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Answer
{
    [SerializeField] private string info;
    public string Info { get { return info;} }

    [SerializeField] private bool esteCorect;
    public bool EsteCorect { get { return esteCorect; } }
}

[CreateAssetMenu(fileName = "Intrebare noua ", menuName = "Test")]
public class Intrebari : ScriptableObject
{

    public enum TipRas { Singur, Multe};

    [SerializeField] private string intrebare = string.Empty;
    public string Intrebare {  
        get 
        { return intrebare; }
    }

    [SerializeField] Answer[] raspunsuri = null;
    public Answer[] Raspunsuri { get { return raspunsuri; } }
    [SerializeField] private bool timp = false;
    public bool Timp { get {  return timp; } }

    [SerializeField] private int secunde = 0;
    public int Secunde { get { return secunde; } }

    [SerializeField] private TipRas tipRas = TipRas.Singur;
    public TipRas GetTipRas {  get { return tipRas; } }

    [SerializeField] private int scor = 10;
    public int Scor { get { return scor;} }

    public List<int> GetRasCor()
    {
        List <int> RasCor = new List<int>();
        for(int i = 0;i< raspunsuri.Length;i++)
        {
            if (raspunsuri[i].EsteCorect == true)
            {
                RasCor.Add(i);
            }
        }
        return RasCor;
    }

}

