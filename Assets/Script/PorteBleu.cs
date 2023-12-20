using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PorteBleu : MonoBehaviour
{
    [SerializeField] private Collider _socketCollider;
    [SerializeField] private GameObject[] _porte;
    [SerializeField] private GameObject _gemme;
    [SerializeField] private AudioClip _sonPorte;
    private AudioSource _audioSource;
    
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "gemmeBleu")
        {

            for (int i = 0; i < _porte.Length; i++)
            {
                Destroy(_porte[i]);
                _audioSource.PlayOneShot(_sonPorte);
            }

        }
        Debug.Log("Porte détruite");

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
