using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcontroller : MonoBehaviour
{

    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(0, 0, speed));
    }
   
    private void OnCollisionEnter(Collision collision) {
       
       if (collision.gameObject.tag == "Target") {
           Destroy(this.gameObject);
           Destroy(collision.gameObject);
           tankcontroller.enemyleft--;
        }
    }

    
}
