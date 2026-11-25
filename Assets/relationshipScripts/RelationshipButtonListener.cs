using UnityEngine;
using UnityEngine.Events;

public class RelationshipButtonListener : MonoBehaviour
{
    public static RelationshipButtonListener Instance;

    [System.Serializable]
    public class ButtonPressedEvent : UnityEvent<int, int, int>
    {
        // relationshipChange, round, npcIndex
    }

    public ButtonPressedEvent OnRelationshipButtonPressed;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        OnRelationshipButtonPressed.AddListener(HandleRelationshipChoice);
    }

    private void HandleRelationshipChoice(int relationshipChange, int round, int npcIndex)
    {
        if (npcIndex < 0 || npcIndex >= RelationshipManager.Instance.npcs.Count)
            return;

        NpcRelationship npc = RelationshipManager.Instance.npcs[npcIndex];

        npc.AddPoints(relationshipChange);

        Debug.Log(
            $"Round {round} | NPC: {npc.npcName} | Change: {relationshipChange}"
        );
    }
}
