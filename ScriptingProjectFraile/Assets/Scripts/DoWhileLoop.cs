using UnityEngine;
using System.Collections;


public class DoWhileLoop : MonoBehaviour
{
    private void Start()
    {
        bool shouldContinue = false;

        do
        {
            print("Hello World");

        } while (shouldContinue == true);
    }
}