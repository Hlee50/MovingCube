using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.name == "Player")
        {
            gameManager.CompleteLevel();
        }
    }
}
