using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AddForce : MonoBehaviour
{

    [SerializeField] public Vector3 force = new Vector3(0, 0, 1);

    [SerializeField] public ForceMode forceMode = ForceMode.Impulse;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(force, forceMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
