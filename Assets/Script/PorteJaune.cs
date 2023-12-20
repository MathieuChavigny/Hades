using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PorteJaune : MonoBehaviour
{
    [SerializeField] private Collider _socketCollider;
    [SerializeField] private GameObject[] _porte;
    [SerializeField] private GameObject _gemme;


    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "gemmeJaune")
        {

            for (int i = 0; i < _porte.Length; i++)
            {
                Destroy(_porte[i]);


            }

        }
        Debug.Log("Porte détruite");

    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

    }
}
