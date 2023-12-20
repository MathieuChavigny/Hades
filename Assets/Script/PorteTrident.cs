using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteTrident : MonoBehaviour
{

    [SerializeField] private GameObject _porte;

    

public void OuvrirPorte(){
    Debug.Log("porte détruite");
    _porte.SetActive(false);
}
}
