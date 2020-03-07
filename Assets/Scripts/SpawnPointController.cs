using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointController : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject gridToSpawn;

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
 

                if(i <= 6 && j <= 5)
                {

                    Instantiate(gridToSpawn, new Vector3(j-3, i-4, 0), Quaternion.identity);
                    gridToSpawn.name = "grid_" + i + "_" + j;
                }

                Instantiate(objectToSpawn, new Vector3(j-3, i-4, 0), Quaternion.identity);
                

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


        if (Input.GetMouseButton(0))
        {


            var touch = Input.mousePosition;



            Vector3 mousePos = Camera.main.ScreenToWorldPoint(touch);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);


            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log("Object Clicked: " + hit.collider.gameObject.name);



            }

        }
 
         
    }
}
