using UnityEngine;

[CreateAssetMenu(fileName = "GridData", menuName = "GameData/GridData")]
public class GridData : ScriptableObject
{
    [Header("Grid Configuration")]
    [Tooltip("���������� ����� ��� �����")]
    public int rows;

    [Tooltip("���������� �������� ��� �����")]
    public int columns;

    [Header("Level Name")]
    public string levelName;
}
