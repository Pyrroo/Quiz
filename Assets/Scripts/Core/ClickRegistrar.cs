using UnityEngine;
public class ClickRegistrar : MonoBehaviour
{
    [SerializeField] private AnswerChecker answerChecker;
    private bool isBlocked = false;
    public void BlockMouse() // Для некликабельности во время рестарта
    {
        isBlocked = true;
    }
    void Update()
    {
        if (!isBlocked)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.GetComponent<Cell>())
                    {
                        answerChecker.Check(hit.collider.gameObject.GetComponent<Cell>());
                    }
                }
            }
        }        
    }
}
