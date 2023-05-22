using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax2 : MonoBehaviour
{
    Material mat;
    public Player player;   
    float distance;
    // Start is called before the first frame update
    [Range(80, 100)]
    public float speed = 0.2f;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        float realVelocity = player.velocity.x / speed;
        distance += realVelocity * Time.deltaTime;
        mat.SetTextureOffset("_MainTex", Vector2.right * distance  );
    }
}
