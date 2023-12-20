using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brazero : MonoBehaviour
{
    int _brazeroActif = 0;

    [SerializeField] private Collider _brazeroCollider1;
    [SerializeField] private Collider _brazeroCollider2;
    [SerializeField] private Collider _brazeroCollider3;
    [SerializeField] private GameObject _porte;

    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private ParticleSystem _particleSystem1;
    [SerializeField] private ParticleSystem _particleSystem2;

    [SerializeField] private AudioClip _sonPorte;
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

        if (other.gameObject.tag == "brazero")
        {
            _brazeroCollider1.isTrigger = false;
            _particleSystem.Play();
            _brazeroActif++;
            Debug.Log("brazero1 actif : " + _brazeroActif);
        }
        else if (other.gameObject.tag == "brazero1")
        {
            _brazeroCollider2.isTrigger = false;
            _particleSystem1.Play();
            _brazeroActif++;
            Debug.Log("brazero2 actif : " + _brazeroActif);
        }
        else if (other.gameObject.tag == "brazero2")
        {
            _brazeroCollider3.isTrigger = false;
            _particleSystem2.Play();
            _brazeroActif++;
            Debug.Log("brazero3 actif : " + _brazeroActif);
        }

        if (_brazeroActif == 3)
        {
            _porte.SetActive(false);
            _audio.PlayOneShot(_sonPorte);
        }
    }

}