using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zeus : MonoBehaviour
{

    bool _orbreActif = false;
    bool _orbre1Actif = false;

    [SerializeField] private Collider _orbreCollider1;
    [SerializeField] private Collider _orbreCollider2;
    [SerializeField] private GameObject _porte;
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private ParticleSystem _particleSystem1;

    [SerializeField] private AudioClip _soncage;
    private AudioSource _audio;
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        _audio = GetComponent<AudioSource>();

    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "orbre")
        {
            _orbreCollider1.isTrigger = false;
            _orbreActif = true;
            _particleSystem.Play();
            Debug.Log("_orbreActif actif : " + _orbreActif);
            _audio.PlayOneShot(_soncage);

        }
        else if (other.gameObject.tag == "orbre1")
        {
            _orbreCollider2.isTrigger = false;
            _orbre1Actif = true;
            _particleSystem1.Play();
            _audio.PlayOneShot(_soncage);
            Debug.Log("_orbreActif actif : " + _orbreActif);
        }



    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (_orbreActif == true && _orbre1Actif == true)
        {

            Destroy(_porte);
        }
    }
}
