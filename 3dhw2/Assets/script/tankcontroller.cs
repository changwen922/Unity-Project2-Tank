
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class tankcontroller : MonoBehaviour
{
          //坦克左边的履带
    public GameObject LeftTrack;
    //坦克右边的履带
    public GameObject RightTrack;
    public static int enemyleft = 5;
    public GameObject MissionCompleted;
    
    public float trackSpeed = 30f;
    public float rotateSpeed = 30f;
    public float moveSpeed = 30f;
    public int flag = 1;
    
    void Start()
    {
        //隐藏任务完成提示
        MissionCompleted.SetActive(false);
       
        enemyleft = 5;
    }
    private void Update()
    {
        flag = 1;
        //坦克向前移动
        if (enemyleft==0 )
        {
            MissionCompleted.SetActive(true);
        }
        if (Input.GetKey(KeyCode.W))
        {
 
          
            //履带滚动效果
            LeftTrack.transform.GetComponent<Renderer>().material.mainTextureOffset += new Vector2(-trackSpeed,0f);
            RightTrack.transform.GetComponent<Renderer>().material.mainTextureOffset += new Vector2(-trackSpeed,0f);
 
            //坦克车身向前移动
            transform.Translate(new Vector3(0f,0f,moveSpeed*Time.deltaTime));
        }
 
        //坦克向后移动
        if (Input.GetKey(KeyCode.S))
        {
 
            
            //履带滚动效果
            LeftTrack.transform.GetComponent<Renderer>().material.mainTextureOffset += new Vector2(trackSpeed, 0f);
            RightTrack.transform.GetComponent<Renderer>().material.mainTextureOffset += new Vector2(trackSpeed, 0f);
 
            //坦克车身向前移动
            transform.Translate(new Vector3(0f, 0f, -moveSpeed * Time.deltaTime));
            flag = -1;
        }
 
        //坦克向左转
        if (Input.GetKey(KeyCode.A))
        {
            
            //履带滚动效果
            LeftTrack.transform.GetComponent<Renderer>().material.mainTextureOffset += new Vector2(-flag*trackSpeed, 0f);
            RightTrack.transform.GetComponent<Renderer>().material.mainTextureOffset += new Vector2(-flag*trackSpeed, 0f);
 
            //坦克车身向左转
            transform.Rotate(new Vector3(0f,-flag*rotateSpeed*Time.deltaTime,0f));
 
        }
        //坦克向右转
        if (Input.GetKey(KeyCode.D))
        {
            
            //履带滚动效果
            LeftTrack.transform.GetComponent<Renderer>().material.mainTextureOffset += new Vector2(-flag*trackSpeed, 0f);
            RightTrack.transform.GetComponent<Renderer>().material.mainTextureOffset += new Vector2(-flag*trackSpeed, 0f);
 
            //坦克车身向右转
            transform.Rotate(new Vector3(0f, flag*rotateSpeed*Time.deltaTime, 0f));
 
        }
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);

    }
}
