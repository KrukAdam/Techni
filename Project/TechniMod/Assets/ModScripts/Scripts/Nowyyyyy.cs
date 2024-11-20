using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Nowyyyyy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DamageSyste.TakTak
        //1
        int x = 10;
        float y = x;

        //2
        float z = 10.44f;
        int b = (int)z;



        var fff = new DamageSyste();
       



        string sssss = "123";
        var oo = Convert.ToInt32(sssss);

        if(int.TryParse(sssss, out int cosTam))
        {

        }
        else
        {

        }

        object obj = new();

        if(obj is Enemy1 model)
        {
            model.id = 1;
        }
        else
        {

        }

        Model test = new();
        Enemy1 enemy1 = test as Enemy1;

        enemy1.Z = 5;

        List<Model> list = new();
        int[] tablica = { 1, 2, 3, 4, 5 };
        Dictionary<string,Model> valuePairs = new();



    }

    public void GetDamage(IEnemy enemy)
    {

    }
}
public enum XYZ
{
    test12,
    test13,
}
public interface IEnemy
{
    public int hp { get; set; }
}


[Serializable]
public class Model : IEnemy
{
    public int id = 1;

    public int hp { get; set; }
}

public class Enemy1 : Model
{
    public int Z = 22;
}

public class Enemy2 : Model
{
    public int Z = 22;
}

public class Test<K> where K : Model
{ 
   public List<K> listK = new();
}
