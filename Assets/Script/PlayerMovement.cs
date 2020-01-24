using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private Rigidbody2D rb;
	public float thrust;
    public float backwardsthrust;
    public float jumpstrength;
    public Transform cursor;
    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (directionx = Input.GetAxisRaw("Horizontal") < 0) {
            rb.AddRelativeForce(Vector3.right * direction * thrust);
            
        }
        if (directiony = Input.GetAxisRaw("Horizontal") > 0) {
            rb.AddRelativeForce(Vector3.up * direction * thrust);
            
        }
    }
}
