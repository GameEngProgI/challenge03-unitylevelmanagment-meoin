using UnityEngine;

public class LevelChangeTrigger : MonoBehaviour
{
    private LevelManager levelManager;

    public GameObject targetLevel;
    public Vector2 targetPosition;

    private void Start()
    {
        levelManager = ServiceHub.Instance.levelManager;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") 
        {
            levelManager.LevelChange(targetLevel, targetPosition);
        }
    }
}
