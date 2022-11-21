using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defineItems : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        Item item = new Item();
        item.Items.Add(new Item("Blood Sword", ""));
        item.Items.Add(new Item("Solar Maze", ""));
        item.Items.Add(new Item("Chaia's Greatsword", ""));
        item.Items.Add(new Item("Moon dagger", ""));
        item.Items.Add(new Item("Tsagan blade", ""));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
