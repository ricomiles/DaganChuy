using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menugrounds : MonoBehaviour
{
    // Start is called before the first frame update

    [Range(5f,20f)]
    public float speed = 10f;

    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x -= Time.deltaTime * speed;
        
        if(pos.x <= -10.56f)
        {
            pos.x = 142.48f;
        }
        transform.position = pos;
    }
}
