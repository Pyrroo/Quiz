using TMPro;
using UnityEngine;
public class TaskDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TaskText;
    public void DisplayNewTask(string task)
    {
        TaskText.text = "Find " + task;
    }
}
