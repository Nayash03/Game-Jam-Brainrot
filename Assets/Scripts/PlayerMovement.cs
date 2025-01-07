using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public float Direction = 4;



    public Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    private Vector3 velocity = Vector3.zero;


    void FixedUpdate()
    {
        
        float horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float verticalMovement = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;


        MovePlayer(horizontalMovement, verticalMovement);

        

        if (Mathf.Abs(rb.velocity.x) > Mathf.Abs(rb.velocity.y))
        {
            float characterVelocity = Mathf.Abs(rb.velocity.x);
            animator.SetFloat("Speed", characterVelocity);
           
        }
        else
        {
            float characterVelocity = Mathf.Abs(rb.velocity.y);
            animator.SetFloat("Speed", characterVelocity);
        }
        animator.SetFloat("Direction", Direction);
    }

    void MovePlayer(float _horizontalMovement, float _verticalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, _verticalMovement);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, 0.05f);

        if (Mathf.Abs(rb.velocity.x) > Mathf.Abs(rb.velocity.y))
        {
            // Mouvement horizontal 
            if (rb.velocity.x > 0.3f)
            {
                Direction = 3; // right
            }
            else if (rb.velocity.x < -0.3f)
            {
                Direction = 2; // left
            }
        }
        else
        {
            // Mouvement vertical 
            if (rb.velocity.y > 0.3f)
            {
                Direction = 1; // top
            }
            else if (rb.velocity.y < -0.3f)
            {
                Direction = 4; // down
            }
        }


    }

    void OnDestroy()
    {
        Debug.LogWarning("Destroy called on player: " + gameObject.name);
    }

    

}
