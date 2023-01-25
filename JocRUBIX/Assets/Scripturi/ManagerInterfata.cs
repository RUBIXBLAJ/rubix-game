using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

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
    [SerializeField] Image resolutieBG;
    public Image ResolutieBG { get { return resolutieBG; } }

    [SerializeField] TextMeshProUGUI resolutionStateInfoText;
    public TextMeshProUGUI ResolutionStateInfoText { get { return resolutionStateInfoText; } }
    [SerializeField] TextMeshProUGUI resolutionScoreText;
    public TextMeshProUGUI ResolutionScoreText { get { return resolutionScoreText; } }

    [Space]

    [SerializeField] TextMeshProUGUI highScoreTXT;
    public TextMeshProUGUI HighScoreTXT { get { return highScoreTXT; } }

    [SerializeField] CanvasGroup mainCanvas;
    public CanvasGroup MainCanvas { get { return mainCanvas; } }

    [SerializeField] RectTransform elementeTerminate;
    public RectTransform ElementeTerminate { get { return elementeTerminate; } }






}

public class ManagerInterfata : MonoBehaviour
{
    public enum ResolutionScreenType {  Corect, Incorect, Terminat }

    [Header("Referinte")]
    [SerializeField] MeniuJoc joc;

    [Header("Elemente Ui (Prefab)")]
    [SerializeField] DataRaspunsuri prefabRas;

    [SerializeField] ElementeUI elementeUi;

    [Space]
    [SerializeField] ParametriUI parametri;

    List<DataRaspunsuri> raspunsCurent = new List<DataRaspunsuri>();

    private void OnEnable()
    {
        joc.UpdateQuestionUI += UpdateQuestionUI;
    }
    private void OnDisable()
    {
        joc.UpdateQuestionUI += UpdateQuestionUI;
    }
    void UpdateQuestionUI(Intrebari intrebari)
    {
        elementeUi.ObjIntrebareTXT.text = intrebari.Intrebare;
        CreareIntrebare(intrebari);


    }

    void CreareIntrebare(Intrebari intrebari)
    {
        StergeRaspunsuri();

        float offstet = 0 - parametri.Margini;
        for(int i = 0;i < intrebari.Raspunsuri.Length;i++)
        {
            DataRaspunsuri rasNou = (DataRaspunsuri)Instantiate(prefabRas, elementeUi.ArieRaspunsuri);
            rasNou.UpdateData(intrebari.Raspunsuri[i].Info,i);

            rasNou.Rect.anchoredPosition = new Vector2(0, offstet);

            offstet -= (rasNou.Rect.sizeDelta.y + parametri.Margini);
            elementeUi.ArieRaspunsuri.sizeDelta = new Vector2(elementeUi.ArieRaspunsuri.sizeDelta.x, offstet * -1);

            raspunsCurent.Add(rasNou);

        }
    }

    void StergeRaspunsuri()
    {
        foreach(var raspuns in raspunsCurent)
        {
            Destroy(raspuns.gameObject);
        }
        raspunsCurent.Clear();
    }

}
