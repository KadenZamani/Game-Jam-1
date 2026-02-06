using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    public Vector3 moveDirection = Vector3.right;   // Direction it moves
    public float distance = 5f;                     // How far it moves
    public float speed = 2f;                        // How fast it moves

    private Vector3 startPos;
    private Vector3 endPos;
    private float t;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        endPos = startPos + moveDirection.normalized * distance;
    }

    // Update is called once per frame
    void Update()
    {
        // PingPong creates smooth back-and-forth motion
        t = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(startPos, endPos, t);
    }
}
