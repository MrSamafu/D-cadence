using UnityEngine;

public class openDoorLabo : MonoBehaviour
{
    public GameObject door;
    public Animator anim;

  
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            anim.SetBool("Open", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("Open", false);
        }
    }
}
