using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	//Name
	string Name = "default";
	
	//Birthday
	string Birthday = "2015-05-01";
	
	//Interest
	string Interest = "datfault";
	
	//Sex
	bool sexSWMale = false;
    bool sexSWFeMale = false;
	bool sexSWOther = false;
	
	//Email
	string Email = "example@example.com";
	
	//History
	string History = "CEO";
	
	//Job
	string Job = "Business Man";
	
	//Address 
	string Address = "Kaoshiung";
	
	//Mobile
	string Mobile = "0986552255";
	
	//Phone
	string Phone = "00755336699";
	
	//Education
	string Education = "CC";
	
	//Department
	string Department = "CSIE";
	
	//Target
	string Target = "Big";
	
	//Skill
	string Skill = "Need Change Skill to Toggle * 5";
	
	//Married
	string Married = "Need Change Married to Toggle *2";
	
	void OnGUI() {
		
		//left,top,width,height
		
		//FullName
		GUI.Label(new Rect(10, 10, 1000, 20),"Please Enter FullName:");
        Name = GUI.TextField(new Rect(150, 10, 200, 20), Name, 25);

		//Birthday, format (2015-2-2)
		GUI.Label(new Rect(10, 40, 1000, 20),"Please Enter Birthday:");
        Birthday = GUI.TextField(new Rect(150, 40, 200, 20), Birthday, 10);
		
		//Interest
		GUI.Label(new Rect(10, 70, 1000, 20),"Please Enter Interest:");
        Interest = GUI.TextField(new Rect(150, 70, 200, 20), Interest, 50);
		
		//Sex
		GUI.Label(new Rect(10, 100, 1000, 20),"Please Enter Sex:");
		sexSWMale = GUI.Toggle(new Rect(150, 100, 100, 20), sexSWMale, " is Male");
		sexSWFeMale = GUI.Toggle(new Rect(250, 100, 100, 20), sexSWFeMale, " is FeMale");
		sexSWOther = GUI.Toggle(new Rect(350, 100, 100, 20), sexSWOther, " is Other");
		
		//Email
		GUI.Label(new Rect(10, 130, 1000, 20),"Please Enter Email:");
        Email = GUI.TextField(new Rect(150, 130, 200, 20), Email, 50);
		
		//History
		GUI.Label(new Rect(10, 160, 1000, 20),"Please Enter History:");
        History = GUI.TextField(new Rect(150, 160, 200, 20), History, 50);
		
		//Job
		GUI.Label(new Rect(10, 190, 1000, 20),"Please Enter Job:");
        Job = GUI.TextField(new Rect(150, 190, 200, 20), Job, 25);
		
		//Address
		GUI.Label(new Rect(10, 220, 1000, 20),"Please Enter Address:");
        Address = GUI.TextField(new Rect(150, 220, 200, 20), Address, 25);
		
		//Mobile
		GUI.Label(new Rect(10, 250, 1000, 20),"Please Enter Mobile:");
        Mobile = GUI.TextField(new Rect(150, 250, 200, 20), Mobile, 25);
		
		//Phone
		GUI.Label(new Rect(10, 280, 1000, 20),"Please Enter Phone:");
        Phone = GUI.TextField(new Rect(150, 280, 200, 20), Phone, 25);
		
		//Education
		GUI.Label(new Rect(10, 310, 1000, 20),"Please Enter Education:");
        Education = GUI.TextField(new Rect(150, 310, 200, 20), Education, 25);
		
		//Main
		GUI.Label(new Rect(10, 340, 1000, 20),"Please Enter Department:");
        Department = GUI.TextField(new Rect(150, 340, 200, 20), Department, 25);
		
		//Target
		GUI.Label(new Rect(10, 370, 1000, 20),"Please Enter Target:");
        Target = GUI.TextField(new Rect(150, 370, 200, 20), Target, 25);
		
		//Skill
		GUI.Label(new Rect(10, 400, 1000, 20),"Please Enter Skill:");
        Skill = GUI.TextField(new Rect(150, 400, 200, 20), Skill, 25);
		
		//Married
		GUI.Label(new Rect(10, 430, 1000, 20),"Please Enter Marred:");
        Married = GUI.TextField(new Rect(150, 430, 200, 20), "2015-05-01", 25);
		
	}
}
