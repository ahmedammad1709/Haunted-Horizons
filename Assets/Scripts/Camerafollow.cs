using UnityEngine;

public class Camerafollow : MonoBehaviour
{

    private Transform player;
    private Vector3 tempPos;

    [SerializeField]
    private float maxX, minX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player  = GameObject.FindWithTag("Player").transform;
       
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player)
            return;
        
        tempPos = transform.position;
        tempPos.x = player.position.x;

        if(tempPos.x > maxX) 
            tempPos.x = maxX;
        if(tempPos.x < minX)
            tempPos.x = minX;

        transform.position = tempPos;
    }
}
