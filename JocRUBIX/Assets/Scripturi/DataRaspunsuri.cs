using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Diagnostics;

public class DataRaspunsuri : MonoBehaviour
{
    [Header("Elemente Interfata")]
    [SerializeField] TextMeshProUGUI txtIntreb;
    [SerializeField] Image toggle;

    [Header("Texturi")]
    [SerializeField] Sprite uncheck;
    [SerializeField] Sprite check;

    [Header("Referinte")]
    [SerializeField] MeniuJoc joc;

    private RectTransform rect;
    public RectTransform Rect
    {
        get
        {
            if(rect == null)
            {
                rect = GetComponent<RectTransform>() ?? gameObject.AddComponent<RectTransform>();
            }
            return rect;
        }
    }

    private int indexRas = -1;
    public int IndeRas { get { return indexRas; } }
    private bool Checked = false;


    public void UpdateData(string info, int index)
    {
        txtIntreb.text = info;
        indexRas = index;
    }

    private void Reset()
    {
        Checked = false;
        UpdateUI();
    }
    public void SwitchTate()
    {
        Checked = !Checked;
        UpdateUI();

        if(joc.UpdateQuestionAnswer !=null)
        {
            joc.UpdateQuestionAnswer(this);
        }

    }

    private void UpdateUI()
    {
        toggle.sprite = (Checked) ? check : uncheck;
    }
}
