using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehaviour : MonoBehaviour
{

    [SerializeField] GameObject prefab;

    bool _gameOver = false;

    // Spawns a new Object prefab
    public void SpawnObject()
    {
        // creates a random number between -8 and 8
        int randomXPosition = Random.Range(-8, 8);

        // creates  new game object / prefab
        Instantiate(prefab, new Vector3(randomXPosition, 8f, 0f), Quaternion.identity);

    }



    private void OnCollisionEnter2D(Collision2D collision) {
        
        // player collides with object and game oover is false
        if(collision.gameObject.tag == "Player" && _gameOver == false){
            // spawn new object
            SpawnObject();
            Destroy(gameObject);
        }


        // object touch the ground
        if(collision.gameObject.tag == "Ground" ){

            _gameOver = true;
        }



    }


}
