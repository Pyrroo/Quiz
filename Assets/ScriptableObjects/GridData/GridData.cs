using UnityEngine;

[CreateAssetMenu(fileName = "GridData", menuName = "GameData/GridData")]
public class GridData : ScriptableObject
{
    [Header("Grid Configuration")]
    [Tooltip("Количество строк для сетки")]
    public int rows;

    [Tooltip("Количество столбцов для сетки")]
    public int columns;

    [Header("Level Name")]
    public string levelName;
}
