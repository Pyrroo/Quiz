using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestarter : MonoBehaviour
{
    public void RestartScene() // �� ������ ����� ������� � ��������� ���� � ��, �������� ��� ��� �� ����
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
