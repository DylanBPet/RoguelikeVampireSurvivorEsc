using System.IO;
using UnityEngine;

public class EnemyBehaviourScript : MonoBehaviour
{
    public GameObject playerPos;

    public float aggroRange;

    // Update is called once per frame
    void Update()
    {
       Vector2 direction = playerPos.transform.position - transform.position;
       Vector2 endLine = (Vector2)transform.position + (direction.normalized * aggroRange);
       Debug.DrawLine(transform.position, endLine);

        float distance = Vector2.Distance(playerPos.transform.position, transform.position);
        if (distance < aggroRange)
        {
            Debug.DrawLine(transform.position, endLine, Color.red);
        }
        
    }
}
