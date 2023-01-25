using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
[Serializable()]
public struct ParametriUI
{
    [Header("Optiuni Raspuns")]
    [SerializeField] float margini;
    public float Margini { get { return margini; } }
}

[Serializable()]
public struct ElementeUI
{
    [SerializeField] RectTransform arieRaspunsuri;
    public RectTransform ArieRaspunsuri { get { return arieRaspunsuri; } }

    [SerializeField] TextMeshProUGUI objIntrebareTXT;
    public TextMeshProUGUI ObjIntrebareTXT { get { return objIntrebareTXT; } }

    [SerializeField] TextMeshProUGUI scorTXT;
    public TextMeshProUGUI ScorTXT { get { return scorTXT; } }
    [Space]
    [SerializeField] TextMeshProUGUI highScoreTXT;
    public TextMeshProUGUI HighScoreTXT { get { return highScoreTXT; } }




}

public class ManagerInterfata : MonoBehaviour
{
    public enum ResolutionScreenType {  Corect, Incorect, Terminat }

    [Header("Referinte")]
    [SerializeField] MeniuJoc joc;

    [Header("Elemente Ui (Prefab)")]
    [SerializeField] DataRaspunsuri prefabRas;


    [SerializeField] ParametriUI parametri;


}
