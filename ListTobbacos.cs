using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTobbacos : Tobbaco
{
    //public Product ds = new Tobbaco("Darkside",new List<string>(){"Admiral Acbar", "Side Astro Tea" });

    public Tobbaco ds;


    
    private void Start()
    {
        ds = GetComponent<Tobbaco>();


        ds.nameTobbaco = "Darkside";
        ds.nameTastes.AddRange(new List<string>() { "Admiral Acbar", "Side Astro Tea" });
        ds.nameTastes.Add("Admiral Acbar");
        ds.nameTastes.Add("Side Astro Tea");

        ds.ShowList();
    }
}
