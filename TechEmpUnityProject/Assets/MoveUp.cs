using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position.Set(this.transform.position.x, this.transform.position.y + Time.deltaTime, this.transform.position.z);
    }
}
