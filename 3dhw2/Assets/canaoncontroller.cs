using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canaoncontroller : MonoBehaviour
{

    public GameObject Cannon;
    public GameObject Head;
    public float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float v = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        Head.transform.Rotate(new Vector3(v, 0, 0));
        Cannon.transform.Rotate(new Vector3(0, h, 0));

    }
}
