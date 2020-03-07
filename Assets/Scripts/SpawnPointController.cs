using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointController : MonoBehaviour
{
    public GameObject objectToSpawn;

    private Sprite[] listOfSprites;

    public Sprite appleSprite;
    public Sprite mangoSprite;
    public Sprite bananaSprite;


    bool RestrictRandom()
    { 
         

        return true;

    }

    void SpawnObject()
    {
       
        var sprite = objectToSpawn.GetComponent<SpriteRenderer>();

        listOfSprites = new Sprite[3];
        listOfSprites[0] = appleSprite;
        listOfSprites[1] = mangoSprite;
        listOfSprites[2] = bananaSprite;
         
         

        for (int i = 1; i <= 10; i++)
        {

            for(int j =1; j <= 5; j++)
            {

                var random = Random.Range(0, 3); 
 
                 

                Instantiate(objectToSpawn, new Vector3(j-3, i-3, 0), Quaternion.identity);
                objectToSpawn.name = "Slot_" + i + "_" + j;

                sprite.sprite = listOfSprites[random];

            }



            
        } 
        

    }

    // Start is called before the first frame update
    void Start()
    {
        SpawnObject();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
