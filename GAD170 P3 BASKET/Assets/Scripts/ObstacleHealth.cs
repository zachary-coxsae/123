
using UnityEngine;
using UnityEngine.EventSystems;

public class ObstacleHealth : MonoBehaviour
{
    public int health = 3;
    public Object obstacle;
    public Ball ball;
    public EventTrigger.TriggerEvent respawnTrigger;

    public void TakeDamage(int damageAmount)
    {
        Debug.Log("here "+ damageAmount);
        this.health -= damageAmount;
        this.GetComponent<SpriteRenderer>().color = Color.red;
        Invoke("StopDamage", 0.2f);
    }
    void StopDamage()
    {
        this.GetComponent<SpriteRenderer>().color = Color.white;
    }
    private void Update()
    {
        if (health == 0)
        {
            GameEvents.OnObstacleDestroyed?.Invoke(this);
            Destroy(obstacle);
        }
    }
}
