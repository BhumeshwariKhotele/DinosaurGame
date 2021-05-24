using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockOneScript : MonoBehaviour
{
     
    public GameObject ObstacleObj;
    private float level=1.0f;
    // Update is called once per frame
    void Start()
    {
        GameObject obstacleRef = Instantiate(ObstacleObj);
        obstacleRef.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + level,this.transform.position.z);
    }
}
