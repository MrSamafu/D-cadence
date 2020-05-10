using System;
using UnityEngine;

public class EnterVehicule : MonoBehaviour
{
    public Behaviour[] carScript;
    public Behaviour[] playerScripts;
    public GameObject player;
    private bool inCar = false;
    public GameObject exit;
    public Camera playerCam;
    public Camera carCam;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetButtonDown("Action") && inCar == false)
            {
                playerCam.enabled = false;
                carCam.enabled = true;
                Destroy(player);
                inCar = true;
                for (int i = 0; i < carScript.Length; i++)
                {
                    carScript[i].enabled = true;
                }
                
                Debug.Log("Vous entré dans la voiture" + inCar);
            }
            if(Input.GetButtonDown("Action") && inCar == true)
            {
                Instantiate(player, exit.transform.position, Quaternion.identity);
                playerCam.enabled = true;
                carCam.enabled = false;
                inCar = false;
                for (int i = 0; i < carScript.Length; i++)
                {
                    carScript[i].enabled = false;
                }
                
                Debug.Log("Vous sortez dans la voiture" + inCar);
            }
        }
    }
}
