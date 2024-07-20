using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainscreen : MonoBehaviour
{
    public float Speed;
    Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Speed += Time.deltaTime * 1f;
        float yoffset = (Time.time * Speed);
        renderer.material.SetTextureOffset("_MainTex", new Vector2(yoffset,0f));
    }

}
