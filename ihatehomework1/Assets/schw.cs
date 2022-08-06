using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schw : MonoBehaviour
{
    int health = 100;
    string hero = "mr.icantdothis";
    int damageDealt;
    int boostedHealth; 

    // Start is called before the first frame update
    void Start()
    {
        damageDealt = Damage();
        boostedHealth = Boost();

        print("damage dealt" + damageDealt);
        print("boosted health" + boostedHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Damage ()
    {

        return health - 20;
    }

   int Boost()
    {

        return health += 30;
    }
     
    
}
