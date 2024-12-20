using System.Collections.Generic;
using UnityEngine;

public class TaskGenerator : MonoBehaviour
{
    [SerializeField] private AnswerChecker answerChecker;
    [SerializeField] private TaskDisplay taskDisplay;

    private Sprite currentTask;
    private string currentTaskString;
    private Dictionary<Sprite, bool> pastTasks = new Dictionary<Sprite, bool>();

    public Sprite GenerateTask(SerializablePair<Sprite, string>[] pairs)
    {
        int randomIndex = Random.Range(0, pairs.Length);

        if (pastTasks.ContainsKey(pairs[randomIndex].GetKey()) && pastTasks[pairs[randomIndex].GetKey()])
        {
            int tmprandomIndex = Random.Range(0, pairs.Length);
            while (pastTasks.ContainsKey(pairs[tmprandomIndex].GetKey()) && pastTasks[pairs[tmprandomIndex].GetKey()])
            {
                tmprandomIndex = Random.Range(0, pairs.Length);
            }
            currentTask = pairs[tmprandomIndex].GetKey();
            currentTaskString = pairs[tmprandomIndex].GetValue();
        }
        else
        {           
            currentTask = pairs[randomIndex].GetKey();
            currentTaskString = pairs[randomIndex].GetValue();
        }  
        
        if (!pastTasks.ContainsKey(currentTask))
        {
            pastTasks[currentTask] = true;
        }
        else
        {
            pastTasks[currentTask] = true;
        }

        answerChecker.SetAnswer(currentTask);
        taskDisplay.DisplayNewTask(currentTaskString);

        return currentTask;
    }
    public bool CheckAnswer(Sprite selectedSymbol)
    {
        return selectedSymbol == currentTask;
    }
    public void ClearPastTasks()
    {
        pastTasks.Clear();
    }
}
