using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    Material mat;
    public Player player;
    float distance;
    // Start is called before the first frame update
    [Range(0.1f, 0.5f)]
    public float speed = 0.2f;
    void Start()
    {
        
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        distance += Time.deltaTime * speed;
        mat.SetTextureOffset("_MainTex", Vector2.right * distance);
    }
}
