using UnityEngine;

public class LevelSwaper : MonoBehaviour
{
    [SerializeField] private RestartCanvasLoader canvasloader;
    [SerializeField] private LevelStarter levelStarter;
    [SerializeField] private DataLoader dataLoader;

    private int currentLevel = -1;
    private GameContent gameContent;
    private GridData[] GridDataArray;

    public void NextLevel()
    {
        // Для того, что бы можно было поменять во время игры
        gameContent = dataLoader.GetGameContent();
        GridDataArray = dataLoader.GetGridData();

        currentLevel++;

        if(currentLevel < GridDataArray.Length)
        {
            SwapLevel();
        }
        else
        {
            canvasloader.RestartCanvasload();
        }        
    }
    public void SwapLevel()
    {
        levelStarter.StartLevel(GridDataArray[currentLevel], gameContent, currentLevel);
    }
}
