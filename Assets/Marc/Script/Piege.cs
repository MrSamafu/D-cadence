using UnityEngine;

public class Piege : MonoBehaviour
{
    public GameObject cube;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject)
        {
            cube.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
 