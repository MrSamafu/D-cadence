using UnityEngine;

public class PiegeSamson : MonoBehaviour
{
    public GameObject cube;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            cube.GetComponent<Rigidbody>().isKinematic = false;
            Debug.Log(other.gameObject);
        }
    }
    
}
