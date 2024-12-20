using UnityEngine;

public class DataLoader : MonoBehaviour
{
    [SerializeField] private GridData[] GridDataArray;
    [SerializeField] private GameContent gameContent;

    public GridData[] GetGridData()
    {
        return GridDataArray;
    }
    public GameContent GetGameContent()
    {
        return gameContent;
    }
}
