using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class trident : MonoBehaviour
{
    [SerializeField] private SOTrident _SOTrident;

    [SerializeField] private GameObject _tridentFait;
    [SerializeField] private GameObject _tridentNonFait;
    [SerializeField] private XRGrabInteractable _CollidertridentNonFait;
    [SerializeField] private Transform _positionTridentFait;



    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        _SOTrident.nbTrident = 0;
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        Debug.Log("nbTrident : " + _SOTrident.nbTrident);


    }
    // OnTriggerEnter est appelé lorsque le Collider other entre dans le trigger.
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            _SOTrident.nbTrident++;
            if (_SOTrident.nbTrident >= 4)
            {
                Debug.Log("porte détruite");
                _CollidertridentNonFait.enabled = false;
                Instantiate(_tridentFait, _positionTridentFait.position, _positionTridentFait.rotation);
                Destroy(_tridentNonFait);
            }

        }
    }

    /// <summary>
    /// OnTriggerExit is called when the Collider other has stopped touching the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.layer == 7)
        {
            _SOTrident.nbTrident--;

        }
    }

}
