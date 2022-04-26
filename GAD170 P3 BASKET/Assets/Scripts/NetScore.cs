using UnityEngine;
using UnityEngine.EventSystems;
public class NetScore : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //checks surface that collided with the ball
        Ball ball = collision.gameObject.GetComponent<Ball>();

        //checks if the ball is present
        if (ball != null)
        {

            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
            
        }
    }
}
