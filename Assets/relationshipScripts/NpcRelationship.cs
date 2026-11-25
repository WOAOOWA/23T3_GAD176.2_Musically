using UnityEngine;

public class NpcRelationship : MonoBehaviour
{
    [Header("NPC Info")]
    public string npcName;

    [Header("Relationship")]
    [SerializeField] private int relationshipPoints;

    public int RelationshipPoints => relationshipPoints;

    public void AddPoints(int amount)
    {
        relationshipPoints += amount;

        Debug.Log($"{npcName} relationship changed by {amount}. Total: {relationshipPoints}");
    }
}
