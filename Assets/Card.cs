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
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Card;*/

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0,"Bullet",1,2,$"inflige {this.GetDamage()} dégats"));
        cardList.Add(new Card(1,"Fire Bullet",1,3,$"inflige {damage} dégats et brulure"));
        cardList.Add(new Card(2,"Electric Bullet",1,2,$"inflige {damage} dégats et Shock"));
        cardList.Add(new Card(3,"Poison Bullet",1,2,$"inflige {damage} dégats et poison"));
        cardList.Add(new Card(4,"Honey Bullet",1,2,$"inflige {damage} dégats et honeyed"));
        cardList.Add(new Card(5,"Water Bullet",1,1,$"inflige {damage} dégats et wet"));
        cardList.Add(new Card(6,"Necro-Bullet",1,2,$"inflige {damage} dégats et fear"));
        cardList.Add(new Card(7,"Light-Bullet",1,2,$"inflige {damage} dégats et lighted"));
    }
}


}
