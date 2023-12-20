using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SOZeus", menuName = "ScriptableObjects/SOZeus", order = 1)]
public class SOZeus : ScriptableObject
{
    [SerializeField] private int _nbTete = 0;
    public int nbTete { get => _nbTete; set => _nbTete = value; } //accesseur pour permettre l'acces par l'exterieur du script


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
