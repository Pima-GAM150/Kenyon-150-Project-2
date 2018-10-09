using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour {
    //this script exists to function as a singleton for game management purposes. there should only ever be one of this object loaded at any time

    //declaring a public static instance of this class is done to manage the one instance that should continue to exist
    //declaring it with {get; private set} ensures that no other script may delete this value
    public static Singleton Instance { get; private set; }

    //start of space for variables and properties







    //end of space for variables and properties

    //awake is called before any start methods
    private void Awake()
    {
        //this if/else checks if any instances of this object exist
        if (Instance = null)
        {
            Instance = this;//sets this instance to be the One True Instance
            DontDestroyOnLoad(gameObject);//prevents the parent object of this script being destroyed and recreated at the start of scenes
        }//end if
        else// this else activates if there are duplicates of the singleton in existence
        {
            Destroy(gameObject);//there can only be ONE
        }//end else


    }// end of Awake

	// Use this for initialization
	void Start ()
    {
		
	}//end of Start
	
	// Update is called once per frame
	void Update ()
    {
		
	}//end of Update
}//end of class
