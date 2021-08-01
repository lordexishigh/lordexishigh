using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatforms : MonoBehaviour
{
    //public GameObject loc1;
    //public GameObject loc2;

    public GameObject[] loc;
    private int currentPosition;

    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        //target = loc1;
        currentPosition = 0;
        target = loc[0];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(gameObject.transform.position == target.transform.position)
        {
            if (loc.Length > currentPosition + 1) { currentPosition++; }
            else { currentPosition = 0; }

            target = loc[currentPosition];
        }

        else
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, 0.03f);
        }
    }
}
