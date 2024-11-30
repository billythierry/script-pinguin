using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItemScript : MonoBehaviour
{
    private const bool EcoTrigger = false;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logic.addEcoScore(1);
            Destroy(gameObject);
        }
    }
}
