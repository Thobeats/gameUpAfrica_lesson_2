using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float delayTime = 2.0f;
    private float counter;
    // Update is  vv x`called once per frame


    void Start(){
        Debug.Log("Game Start");
    }


    void Update()
    {
        counter += Time.deltaTime;
         // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
                if(counter > delayTime){
                    SpawnDog();

                    counter = 0f;
                }
           
        }

        

    }

    private void SpawnDog(){       
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
