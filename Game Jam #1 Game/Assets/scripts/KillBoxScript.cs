using UnityEngine;

public class KillBoxScript : MonoBehaviour
{
    [SerializeField] public GameObject respawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = respawnPoint.transform.position;
        }
    }

}
