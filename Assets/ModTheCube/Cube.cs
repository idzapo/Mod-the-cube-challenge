using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float speed = 50.0f;

    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.7f, 0.7f, 1.0f, 1.0f);
        //material.color = new Color32(102, 102, 255, 200);
    }
    
    void Update()
    {
        //transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-speed * Time.deltaTime, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0.0f, -speed * Time.deltaTime, 0.0f);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(0.0f, speed * Time.deltaTime, 0.0f);
        }
    }
}
