using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public Collection<string> _items;
    public Collection<GameObject> _objInventory;
    private bool _isOpen;
    private GameObject _inventory;



    void Start()
    {
        _items = new Collection<string>();
        _inventory = GameObject.Find("Inventory");
        Debug.Log(this.gameObject.name);
        _isOpen= false;
        _inventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && !_isOpen)
        {
            _isOpen= true;
            _inventory.SetActive(true);
            Debug.Log("abriendo");
        }
        else if (Input.GetKeyDown(KeyCode.I) && _isOpen)
        {
            _isOpen= false;
            _inventory.SetActive(false);
            Debug.Log("cerrando");
        }
    }



    public void UpdateInventory()
    {

        foreach (string item in _items)
        {

        }
    }
}
