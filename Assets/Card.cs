using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private int id;
    private string name;
    private int cost;
    private int damage;
    private string description;

    public Card() 
    {

    }

     public Card(int id, string name, int cost, int damage, string description) 
    {
        SetId(id);
        SetName(name);
        SetCost(cost);
        SetDamage(damage);
        SetDescription(description);
    }

    // getter
    public int GetId() 
    {
        return this.id;
    }

    public string GetName() 
    {
        return this.name;
    }

    public int GetCost() 
    {
        return this.cost;
    }

    public int GetDamage() 
    {
        return this.damage;
    }

    public string GetDescription()  
    {
        return this.description;
    }

    // setter
    public void SetId(int id)
    {
        this.id = id;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetCost(int cost)
    {
        this.cost = cost;
    }

    public void SetDamage(int damage)
    {
        this.damage = damage;
    }

    public void SetDescription(string description) 
    { 
        this.description = description; 
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
