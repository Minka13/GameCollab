 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    [SerializeField]
    private Rigidbody playerBody;

    private Vector3 inputVector;
    // Start is called before the first frame update
    void Start() {
        playerBody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update() {
        
        inputVector = new Vector3(Input.GetAxis("Horizontal") * 10f, playerBody.velocity.y , Input.GetAxis("Vertical") * 10f);
        
        playerBody.velocity = inputVector;

    }
}
 