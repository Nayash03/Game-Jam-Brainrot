using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;

    
    private Transform target;
    private int destPoint = 0;
    private bool isShoot = false;

    void Start()
    {
        target = waypoints[0];
    }


    void Update()
    {
        if (isShoot) 
        {
            Vector3 dir = target.position - transform.position;
            
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

            // Si l'ennemi est quasiment arrivé à sa destination
            if (Vector3.Distance(transform.position, target.position) < 0.3f)
            {
                destPoint = (destPoint + 1) % waypoints.Length;
                target = waypoints[destPoint];
         
            }
        }
        
        if (Input.GetButtonDown("Fire1"))
        {
            isShoot = true; 
        }
    }
}
