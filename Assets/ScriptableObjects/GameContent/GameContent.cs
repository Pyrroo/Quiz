using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameContent", menuName = "GameData/GameContent")]
public class GameContent : ScriptableObject
{
    [Header("Game Objects")]
    [Tooltip("������ �������� ��� ����������� � �������")]
    
    
    public SerializablePair<Sprite, string>[] SymbolTranscriptPairs;
}
