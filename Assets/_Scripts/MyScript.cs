using UnityEngine;

public class MyScript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    
    [SerializeField] private int forceValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("Hello");
        //rb.AddForce(new Vector3.down(0, -50, 0));
        rb.AddForce(new Vector3(0, forceValue, 0));
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello");
    }
}
