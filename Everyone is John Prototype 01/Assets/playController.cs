using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playController : MonoBehaviour {

    public InputField nameInput;
    public static string playerName;

    public InputField skillInput1;
    public static string skill1;
    public InputField skillInput2;
    public static string skill2;
    public InputField skillInput3;
    public static string skill3;
     
    public InputField obsessionInput1;
    public static string obsession1;
    public InputField obsessionInput2;
    public static string obsession2;
    public InputField obsessionInput3;
    public static string obsession3;

    public int totalWillpower = 10;
    public int currWillpower;

    public static int points = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(nameInput.text);
        playerName = nameInput.text;
	}

    public void setName(string n)
    {
        playerName = name;
    }
}
