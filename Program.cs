
using System.Runtime.Serialization;

public class Student {
    //private property
    private string? _name;//private var
    //"?"to handle null value & "_"is best practice for private naming convention
    private DateTime _dateOfBirth;//private var
    private string? _rollNumber;//private var

//property
    public string? Name {      
        get {return _name;}
        set {_name = value;}
    }
    public DateTime DateOfBirth  {
        get {return _dateOfBirth;}
        set {
            if (value > DateTime.Now){
                throw new ArgumentException ("Date can not be in the future");
            }   //exception handling
            _dateOfBirth = value;
        }
    }
    public string? RollNumber {
        get {return _rollNumber;}
        set {_rollNumber = value;}
    }
 //constructor => to assign value in property
    public Student(string name, DateTime dateTime, string rollNumber){
        Name = name;
        DateOfBirth = dateTime;
        RollNumber = rollNumber;
        
    }
   
}
//Main class
public class MyClass{
    public static void Main (string[] args){
        try{
            Student student1 = new Student("Tanvir Ahmed", new DateTime (1997,05,14), "CSE41");
            Student student2 = new Student("Partha pratim",new DateTime(2001,06,19),"CSE42");
        }
        catch(Exception ex){
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}