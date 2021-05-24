using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public PlayerMovement player;
    public Camera camfollow;
    public GameObject[] blockObj;
    public float blockArrowPointer =-10.0f;
    public float safeMargin=20;
    public float score=0.0f;
    public Text  scoreText;                                         //public float camOffSetZ;
                                        //Vector3 camoffset;
                                        // Start is called before the first frame update

    void Start()
    {
        print("Welcome to endless Runner Game!\nPress space key to jump and escape from obstacle\n");
    }
     


    // challenge to change the fixed offset to block size offset
    // Update is called once per frame
    
    
    void Update()
    {
       while(player != null &&  blockArrowPointer < player.transform.position.x + safeMargin)
       {
        int value= Random.Range(0,blockObj.Length);
        if(blockArrowPointer < 10)
        {
            value=0;
        }
        GameObject blockGeneratedRef = Instantiate(blockObj[value]); //tested same block sizes with fixed offset
        BlockSize bs=blockGeneratedRef.GetComponent<BlockSize>();
        blockGeneratedRef.transform.position=new Vector3(blockArrowPointer + bs.blockSize/2,0,0);
        blockArrowPointer +=bs.blockSize;
       }
        if(player!=null)
        {
       // camfollow.transform.position=player.transform.position+camoffset;
        score+=Time.deltaTime;
        scoreText.text="Score:"+Mathf.RoundToInt(score).ToString();
        camfollow.transform.position= new Vector3(player.transform.position.x,camfollow.transform.position.y,camfollow.transform.position.z);
        }
    }

    
}
 