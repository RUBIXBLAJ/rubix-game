using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DataRaspunsuri : MonoBehaviour
{
    [Header("Elemente Interfata")]
    [SerializeField] TextMeshPro txtIntreb;
    [SerializeField] Image toggle;

    [Header("Texturi")]
    [SerializeField] Sprite uncheck;
    [SerializeField] Sprite check;

    private int indexRas = -1;
    public int IndeRas { get { return indexRas; }
    }

}
