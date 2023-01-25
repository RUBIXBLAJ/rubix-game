using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "GameEvent", menuName = "Intrebare")]
public class MeniuJoc : ScriptableObject
{
    public delegate void UpdateQuestionUICallback(Intrebari intrebari);
    public UpdateQuestionUICallback UpdateQuestionUI;

    public delegate void UpdateQuestionAnswerCallback(DataRaspunsuri rasAles);
    public UpdateQuestionAnswerCallback UpdateQuestionAnswer;

    public delegate void DisplayResolutionScreenCallback(ManagerInterfata.ResolutionScreenType type, int scor);
    public DisplayResolutionScreenCallback DisplayResolutionScreen;

    public delegate void ScoreUpdateCallback();
    public ScoreUpdateCallback ScoreUpdate;
    public int scorFinalCurent;



}
