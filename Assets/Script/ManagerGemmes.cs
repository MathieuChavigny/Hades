using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGemmes : MonoBehaviour
{
    [SerializeField] private SphereCollider[] socketGemme;

    [SerializeField] private GameObject[] porteEpreuve;
    [SerializeField] private GameObject[] porteOS;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Gemme")
        {

            int etape = 1;
            if (socketGemme[etape].gameObject.name == other.gameObject.name)
            {
                socketGemme[etape].gameObject.SetActive(false);
                porteEpreuve[etape].SetActive(false);
                porteOS[etape].SetActive(false);
                etape++;
            }

        }
    }
}
