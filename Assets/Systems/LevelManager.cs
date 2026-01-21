using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject current;
    private GameObject player;

    private void Start()
    {
        player = ServiceHub.Instance.playerController.gameObject;
    }

    public void LevelChange(GameObject targetLevel, Transform targetPosition) 
    {
        player.transform.position = targetPosition.position;
        current.SetActive(false);
        targetLevel.SetActive(true);
        current = targetLevel;
        
    }
}
