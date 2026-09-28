using System.Collections;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    [SerializeField] private float animalMoveSpeed = 5f;
    [SerializeField] private float waitTime = 0f;
    private bool isWaiting = false;
    private Vector2 waypoints;
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        SetWayPointPosition();
    }

    void FixedUpdate()
    {
        if (!isWaiting)
        {
            Move();
        }
    }

    void SetWayPointPosition()
    {
        waypoints = new Vector2(Random.Range(-8f, 8f), Random.Range(-4f, 4f));
    }

    void Move()
    {
        Debug.Log(waypoints);
        Transform transform = this.transform;
        Vector2 currentPosition = transform.position;
        Vector2 targetPosition = waypoints;
        Vector2 newPosition = Vector2.MoveTowards(currentPosition, targetPosition, animalMoveSpeed * Time.deltaTime);
        rb.MovePosition(newPosition);

        if (Vector2.Distance(currentPosition, targetPosition) < 0.1f && !isWaiting)
        {
            StartCoroutine(MoveToNextWaypoint());
        }
    }
    
    IEnumerator MoveToNextWaypoint()
    {
        isWaiting = true;
        yield return new WaitForSeconds(waitTime);
        SetWayPointPosition();
        isWaiting = false;
    }
}
