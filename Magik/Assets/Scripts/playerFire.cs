using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class playerFire : MonoBehaviour {

    public GameObject playerFireball;
    public Transform playerSpawn;
    float timeElapsed = 0;


    // Use this for initialization
    void Start () {
		
	}

    public void processControl(string controllerString)
    {
        
        Debug.Log(controllerString);
        string[] array = controllerString.Split(' ');
        Debug.Log(array.Length);

        string type;
        string playerX;
        string playerY;
        string playerZ;
        if (array.Length > 5)
        {
            type = array[0];
            type.Trim();
            playerX = array[2];
            playerY = array[4];
            playerZ = array[6];
        }
        else
        {
            return;
        }
        

        if (type.Equals("Accel"))
        {
            float x = float.Parse(playerX);
            if (x > -5000)
            {
               
                timeElapsed += Time.deltaTime;
                Debug.Log(timeElapsed);
                if (timeElapsed > 0.25)
                {
                    Fire();
                    timeElapsed = 0;
                }
            }
        }
               
    }
	
	// Update is called once per frame
	void Update () {


    }

    void Fire()
    {
        Instantiate(playerFireball, new Vector3(transform.position.x + 2, transform.position.y, transform.position.z),transform.rotation);
    }

}
