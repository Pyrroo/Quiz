using System.Collections.Generic;
using UnityEngine;
public class GridGenerator : MonoBehaviour
{
    [SerializeField] private GameObject cellPrefab;
    [SerializeField] private Transform gridParent;

    private GameObject[,] grid;
    public void GenerateGrid(GridData gridData, List<Sprite> symbols, Sprite task)
    {
        ClearGrid();

        grid = new GameObject[gridData.rows, gridData.columns];

        for (int i = 0; i < gridData.rows; i++)
        {
            for (int j = 0; j < gridData.columns; j++)
            {
                GameObject cell = Instantiate(cellPrefab, gridParent);
                cell.transform.position = gridParent.transform.position;
                grid[i, j] = cell;
            }
        }

        AlignGrid(grid);
        FillGrid(grid, symbols,task);
    }
    public void AddGrid(GridData gridData, List<Sprite> symbols, Sprite task)
    {
        ClearGrid();

        grid = new GameObject[gridData.rows, gridData.columns];

        for (int i = 0; i < gridData.rows; i++)
        {
            for (int j = 0; j < gridData.columns; j++)
            {
                GameObject cell = Instantiate(cellPrefab, gridParent);
                cell.transform.position = gridParent.transform.position;
                grid[i, j] = cell;
            }
        }

        AlignGrid(grid);
        FillAddedGrid(grid, symbols, task);
    }

    private void FillAddedGrid(GameObject[,] gridref, List<Sprite> symbols, Sprite task) // Спавн без анимации
    {
        if (gridref == null || symbols == null || symbols.Count == 0) return;

        List<Sprite> availableSymbols = new List<Sprite>(symbols);
        availableSymbols.Remove(task);

        for (int i = 0; i < gridref.GetLength(0); i++)
        {
            for (int j = 0; j < gridref.GetLength(1); j++)
            {
                if (gridref[i, j] != null)
                {
                    gridref[i, j].GetComponent<Cell>().ReSetSymbol(availableSymbols[Random.Range(0, availableSymbols.Count)]);
                }
            }
        }
        // Рандом таска в случайную клетку
        gridref[Random.Range(0, gridref.GetLength(0)), Random.Range(0, gridref.GetLength(1))].GetComponent<Cell>().ReSetSymbol(task);
    }
    
    private void FillGrid(GameObject[,] gridref, List<Sprite> symbols, Sprite task) // Спавн с анимацией
    {
        if (gridref == null || symbols == null || symbols.Count == 0) return;        

        List<Sprite> availableSymbols = new List<Sprite>(symbols);
        
        availableSymbols.Remove(task);
        for (int i = 0; i < gridref.GetLength(0); i++)
        {
            for (int j = 0; j < gridref.GetLength(1); j++)
            {
                if (gridref[i, j] != null)
                {
                    gridref[i, j].GetComponent<Cell>().SetSymbol(availableSymbols[Random.Range(0, availableSymbols.Count)]);
                }
            }
        }
        // Рандом таска в случайную клетку
        gridref[Random.Range(0, gridref.GetLength(0)), Random.Range(0, gridref.GetLength(1))].GetComponent<Cell>().SetSymbol(task);        
    }
    private void AlignGrid(GameObject[,] gridref)
    {
        if (gridref == null) return;         

        for (int i = 0; i < gridref.GetLength(0); i++)
        {
            for (int j = 0; j < gridref.GetLength(1); j++)
            {
                if (gridref[i, j] != null) 
                {                    
                    gridref[i, j].transform.position = new Vector3(j, -i, 0);
                }
            }
        }
    }
    private void ClearGrid()
    {
        foreach (Transform child in gridParent)
        {
            Destroy(child.gameObject);
        }
    }
}
