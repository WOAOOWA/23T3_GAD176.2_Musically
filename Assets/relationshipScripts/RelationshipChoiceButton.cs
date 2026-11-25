using UnityEngine;

public class RelationshipChoiceButton : MonoBehaviour
{
    [Header("Relationship Change")]
    public int pointValue;

    public void PressButton()
    {
        int round = RelationshipManager.Instance.currentRound;
        int npcIndex = RelationshipManager.Instance.currentNPCIndex;

        RelationshipButtonListener.Instance
            .OnRelationshipButtonPressed
            .Invoke(pointValue, round, npcIndex);
    }
}

//RelationshipButtonListener.Instance
    //.OnRelationshipButtonPressed
    //.Invoke(-5, 2, 1);