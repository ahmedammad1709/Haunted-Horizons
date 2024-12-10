using UnityEngine;

public class Enemy : MonoBehaviour
{
    [HideInInspector]
    public float speed;
    private Rigidbody2D myBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   //by using vector if u jump from back side of monster it will count 10.
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
    }
}
