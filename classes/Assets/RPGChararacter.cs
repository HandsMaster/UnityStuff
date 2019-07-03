using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{
    public int hp;
    public int attack;
    public int defense;
    public int stamina;
    public int speed;
}

public class Equipment
{
    public string head;
    public string body;
    public string legs;
    public string weapons;
}
public class RPGChararacter : MonoBehaviour
{
    Stats stats;
    Equipment equipment;
    List<string> spells;

    void Run(Vector2 destination)
    {
        // TODO: make this work
    }

    void CastSpell(int index)
    {
        string spellName = spells[index];
        //TODO: make this work
    }

    int GetAttack()
    {
        return stats.attack;
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
