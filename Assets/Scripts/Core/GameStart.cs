using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField] LevelSwaper levelSwaper;
    void Start()
    {
        levelSwaper.NextLevel();
    }
}
