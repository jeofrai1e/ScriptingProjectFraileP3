using UnityEngine;
using System.Collections;

public class ConventionsAndSyntax : MonoBehaviour
{
    void Start()
    {
        //this line is there to tell me the X postion of my object

        /*Hi there!
         * This two lines!
         * */
        Debug.Log(transform.position.x);

        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}