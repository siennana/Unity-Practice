using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hacker : MonoBehaviour
{
    //variables
    string greeting = "Hello, User";
    int level = 0;

    // Start is called before the first frame update
    void Start() {
        showMainMenu(greeting);
    }

    void OnUserInput(string input)
	{
        switch (input) {
            case "1":
                Terminal.WriteLine("You pressed 1!");
                level = 1;
                break;
            case "2":
                Terminal.WriteLine("You pressed 2!");
                level = 2;
                break;
            case "3":
                Terminal.WriteLine("You pressed 3!");
                level = 3;
                break;
            case "menu":
                Terminal.WriteLine("Menu");
                break;
            default: 
                Terminal.WriteLine("Invalid try again");
                break;
        }
	}

    void showMainMenu(string greeting) {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the local school");
        Terminal.WriteLine("Press 2 for FaceBook");
        Terminal.WriteLine("Press 3 for BASC");
    }
}
