using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject current;
    private GameObject player;

    private void Start()
    {
        player = ServiceHub.Instance.playerController.gameObject;
    }

    public void LevelChange(GameObject targetLevel, Vector2 targetPosition) 
    {
        current.SetActive(false);
        targetLevel.SetActive(true);
        current = targetLevel;
        player.transform.position = targetPosition;
    }
}
