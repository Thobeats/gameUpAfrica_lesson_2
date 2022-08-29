using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool allowSpawn;
    // Update is  vv x`called once per frame


    void Start(){
        

    }


    void Update()
    {


         // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(SpawnDog());

        }

        

    }

    IEnumerator SpawnDog(){       
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        yield return new WaitForSeconds(3);
    }
}
