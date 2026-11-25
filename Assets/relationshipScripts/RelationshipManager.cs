using UnityEngine;
using System.Collections.Generic;

public class RelationshipManager : MonoBehaviour
{
    public static RelationshipManager Instance;

    [Header("All NPCs")]
    public List<NpcRelationship> npcs = new();

    [Header("Progress Tracking")]
    public int currentNPCIndex;
    public int currentRound;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public NpcRelationship GetCurrentNPC()
    {
        if (currentNPCIndex < 0 || currentNPCIndex >= npcs.Count)
            return null;

        return npcs[currentNPCIndex];
    }

    public void SetCurrentNPC(int npcIndex)
    {
        currentNPCIndex = npcIndex;
    }

    public void NextNPC()
    {
        currentNPCIndex++;

        if (currentNPCIndex >= npcs.Count)
        {
            currentNPCIndex = 0;
            currentRound++;
        }
    }
}

