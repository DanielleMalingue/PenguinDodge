using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
 public GameObject block;
 public float MaxX;
 public Transform spawnPoint;
 public float spawnRate = .5f;

bool gameStarted = false;

    void Start()
    {
        StartCoroutine(SpawnBlock());
    }
        

    // Update is called once per frame
  /*void Update()
    {
        if(Input.acceleration.z > 0.5f && gameStarted == false)
        {
            gameStarted = true;
            Debug.Log("Game started!");
           
        }
    }
*/
   private IEnumerator SpawnBlock()
    {
        while (true){
            yield return new WaitForSeconds(spawnRate);
         Vector3 spawnPos = spawnPoint.position;
         spawnPos.x = Random.Range(-MaxX, MaxX);
            Instantiate(block, spawnPos, Quaternion.identity);

        }
    }


    // Start is called before the first frame update

}


    // Update is called once per frame
  
