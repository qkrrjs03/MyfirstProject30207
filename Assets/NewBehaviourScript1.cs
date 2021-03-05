using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private string name;
    private int Level = 1;

    public Player(string name)
    {
        this.name = name;
    }
    public void GetInfo()
    {
        Debug.Log("이름 : " + name);
        Debug.Log("이름 : " + Level);
    }
    public void LevelUp()
    {
        this.Level++;
        Debug.Log("레벨~업!");
    }
}


public class NewBehaviourScript1 : MonoBehaviour
{
   
    void Start()
    {
        Player myPlayer = new Player("박건");
        myPlayer.GetInfo();
        myPlayer.LevelUp();
        myPlayer.GetInfo();
    }

    
    void Update()
    {
        
    }
}
