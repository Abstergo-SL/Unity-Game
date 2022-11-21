using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    private string _name;
    private string _description;
    private List<Item> _items;

    public Item()
    {

    }

    public Item(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public List<Item> Items
    {
        get { return _items; }
        set { _items = value; }
    }





}
