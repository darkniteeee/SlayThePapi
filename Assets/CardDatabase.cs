using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Card;

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

