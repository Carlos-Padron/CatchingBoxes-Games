using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Props and varaibles

    [SerializeField] Rigidbody2D _rg;
    // Script that handles the logic to spawn Objects
    [SerializeField] ObjectBehaviour _objectBehaviour;
    float _playerSpeed = 5f;
    float _inputHorizontal;



    // Start is called before the first frame update
    void Start()
    {
        // sets the _rg variables to the existing Rigidbody2D of the game object
        _rg = gameObject.GetComponent<Rigidbody2D>();

        // spawns object when the game start
        _objectBehaviour.SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal");


        if (_inputHorizontal != 0)
        {
            float horizontalForce = ((_inputHorizontal * _playerSpeed));
            _rg.AddForce(new Vector2(horizontalForce, 0));

            // _rg.velocity = (new Vector2(horizontalForce, 0));


        }
    }
}
