using UnityEngine;

public class LevelChangeTrigger : MonoBehaviour
{
    private LevelManager levelManager;
    private GameObject player;

    public GameObject targetLevel;
    public Transform targetPosition;

    public bool triggerLocked = false;

    private void OnEnable()
    {
        triggerLocked = GetComponent<BoxCollider2D>().OverlapPoint(player.transform.position);
    }

    private void Awake()
    {
        levelManager = ServiceHub.Instance.levelManager;
        player = ServiceHub.Instance.playerController.gameObject;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && !triggerLocked) 
        {
            levelManager.LevelChange(targetLevel, targetPosition);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            triggerLocked = false;
        }
    }
}
