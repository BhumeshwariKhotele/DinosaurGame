using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockThreeScript : MonoBehaviour
{

    public GameObject ObstacleObj;
    private float level=1.0f;                   //to adjust on top of block

    
    // Start is called before the first frame update
    void Start()
    {
        GameObject obstacleRef = Instantiate(ObstacleObj);
        obstacleRef.transform.position = new Vector3(this.transform.position.x + 7.0f, this.transform.position.y + level,this.transform.position.z);

         GameObject obstacleRef1 = Instantiate(ObstacleObj);
       obstacleRef1.transform.position = new Vector3(this.transform.position.x - 7.0f, this.transform.position.y + level,this.transform.position.z);

        GameObject obstacleRef2 = Instantiate(ObstacleObj);
       obstacleRef2.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + level,this.transform.position.z);
    }

}

