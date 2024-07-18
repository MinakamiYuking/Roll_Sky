using UnityEngine;

public class EndPointTriger : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        FindAnyObjectByType<GameManager>().CompleteLevel();
    }
}
