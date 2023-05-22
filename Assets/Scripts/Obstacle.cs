using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    Player player;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos.x -= player.velocity.x * Time.deltaTime;

        if(pos.x < -100)
        {
            Destroy(gameObject);
            return;
        }

        transform.position = pos;
    }
}
