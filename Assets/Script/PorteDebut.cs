using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PorteDebut : MonoBehaviour
{

    [SerializeField] private Collider _socketCollider;
    [SerializeField] private GameObject[] _porte;
    [SerializeField] private GameObject _gemme;


    void Start()
    {

        // jouerSon();

        // _audio.PlayOneShot(_sonPorte);
    }
    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "gemmeVerte")
        {

            for (int i = 0; i < _porte.Length; i++)
            {
                // jouerSon();
                Destroy(_porte[i]);
            }

        }
        Debug.Log("Porte détruite");

    }

    public void jouerSon()
    {
        // _audio.PlayOneShot(_sonPorte);
    }
    void Update()
    {

    }


}
