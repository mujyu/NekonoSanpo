using UnityEngine;
using System.Collections;

public class CloudController : MonoBehaviour
{
    GameObject cloud;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.04f, 0, 0);
        if(transform.position.x <= -35)
        {
            Destroy(gameObject);
        }
    }
}
