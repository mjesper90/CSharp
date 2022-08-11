/*
* Todays work will be refactoring the Car, Door and Tire class into seperate files
* and laying the ground work for the next assignment
*/

//Instantiating a Car class / Creating an object of type Car
Car car1 = new Car("BMW");
Car car2 = new Car("Toyota", 2, 8, 25);

Console.ReadKey();

//Class definition
class Car{
    #region Fields
    
    public string Brand = ""; 
    protected int CurrentGear = 0;
    private float _speed = 0f;
    internal int _revolutions = 0;
    
    public List<Door> Doors = new List<Door>();
    public List<Tire> Tires;

    #endregion

    #region Constructors

    public Car(string brandParamater){
        this.Brand = brandParamater;
        Tires = new List<Tire>();
        //Brand = brand;
        Doors.Add(new Door());
        Doors.Add(new Door());

        for(int i = 0; i < 4; i++){
            Tires.Add(new Tire(10));
        }
        GetIn(Doors[0]);
        Console.WriteLine("Car constructed / Instantiated");
    }

    public Car(string brandParamater, int amountOfDoors, int amountOfTires, int tireSize){
        //Try to fill out the overloaded constructor
        Console.WriteLine("Car constructed / Instantiated");
    }

    #endregion

    #region Methods
    
    void Break(){
        _speed = 0f;
    }

    void Accelerate(float forceParameter){
        _speed = _speed + forceParameter;
    }
    
    int ChangeGear(int amount){
        CurrentGear += amount;
        return CurrentGear;
    }

    void GetIn(Door doorParameter){
        doorParameter.Open();
        Console.WriteLine("Got inside " + Brand);
        doorParameter.Close();
    }

    #endregion
}

#region Door and Tire Classes

class Door{

    bool IsOpen = false;

    public void Open(){
        if(IsOpen == true){
            Console.WriteLine("Door already open");
        }else{
            Console.WriteLine("Door opened");
            IsOpen = true;
        }
    }

    public void Close(){
        if(IsOpen == false){
            Console.WriteLine("Door already is close");
        }else{
            Console.WriteLine("Door closed");
            IsOpen = false;
        }
    }
}

class Tire{
    public int Size = 0;
    public Tire(int size){
        this.Size = size;
    }
}

#endregion

