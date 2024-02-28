using StudentManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Services
{
    public class Cabinet
    {//a cabinet like a box to store that has more space to store things
        //so if property/attribute is an array!!!
        //may be it has color, label, manufacture,...but we focus on to store thing instead of

        private Student[] _list = new Student[300]; //backing field
        // why I dont use get/set like in Student() class
        //thinks that you have never use the Cabinet in the way that: put 300 profiles at the same time
        //think that: you out one-by-one profile, slowly put each of it into the Cabinet
        //we rarely assign an array (like the normal property) by using one statementand at once
        //We assign the elements of an arrayone-by-one [0] = ..., [1] = ..., [2] = ...,...
        //never arr = ...
        //never _list = ...
        //A box/container will introduce the CRUD methods to allow you to work with the spaces inside the box 
        //open the door of a box, put a new thing into
        //open the door of a box, to find things
        //open the door of a box, to take a desired one, to modify it
        //open the door of a box, to remove the old one
        //CRUD mean Create,     Retrieve            /       Read, Update, Delete
        //               giong SELECT SUM()...Join       giong SELECT * ...

        //SOLID PRINCIPLE
        //S: single responsibility - tính đơn trách nhiệm của hàm/class
        //This class, this method doesnt tight with the input method
        //to make this class more flexible to server multiple kinds of app: console, web, mobile, desktop,..
        //it doesnt have console.readline() to tight with command line 
        //instead, it takes the value via parameters
        //User, dev, you prepare data in somewhere out there 
        //Im here to process your date, store your data
        //the input data mission, the other guy will take it 
        private int _count = 0;//know where to put to the array
        //will be increase one-by-one whenever we put new profile/student

        public void AddNewProfile(string id, string name, string email, int yob, double gpa) 
        {
            _list[_count] = new Student() {Id  = id, Name = name, Email = email, Yob = yob, Gpa = gpa};
            _count++;
        }
        //print the list to see all available profile 
        public void PrintStudentList()
        {
            Console.WriteLine($"There is/are {_count} students in the box: ");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_list[i]); //ToString() in the background
            }
        }

    }
}
