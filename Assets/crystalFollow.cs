using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystalFollow : MonoBehaviour
{
    public Transform spiderTrans;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (spiderTrans.position.x, spiderTrans.position.y + 0.6f, spiderTrans.position.z);
    }
}
