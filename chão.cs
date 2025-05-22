using UnityEngine;

public class chão : MonoBehaviour
{


    public GameObject refPlayer;
    public Transform spawnPoint;
    public GameObject refPrefab;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       // if(Input.GetKeyDown(KeyCode.Z)){


         //  refPlayer.SetActive(true);
           // Destroy(refPlayer);

        //} 

         //if(Input.GetKeyDown(KeyCode.Z)){


           //Destroy(refPlayer);

        // } 
        
        if(Input.GetKeyDown(KeyCode.M)){


             Instantiate(refPrefab, spawnPoint);
             ScoreManager.circleCount++;
      
        }

    }
}
