using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    [SerializeField] private GridGenerator gridGenRef;
    [SerializeField] private TaskGenerator taskGenRef;

    private List<Sprite> spriteArrayFromContent = new List<Sprite>();
    public void StartLevel(GridData gridData, GameContent gameContent, int levelIndex)
    {
        // Вне условия, для возможной замены символов между уровнями
        spriteArrayFromContent.Clear();
        for (int i = 0; i < gameContent.SymbolTranscriptPairs.Length; i++)
        {
            spriteArrayFromContent.Add(gameContent.SymbolTranscriptPairs[i].GetKey());
        }
        if (levelIndex == 0)
        {
            gridGenRef.GenerateGrid(gridData, spriteArrayFromContent, taskGenRef.GenerateTask(gameContent.SymbolTranscriptPairs));
        }
        else
        {
            gridGenRef.AddGrid(gridData, spriteArrayFromContent, taskGenRef.GenerateTask(gameContent.SymbolTranscriptPairs));
        }
    }
}
