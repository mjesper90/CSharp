//Describing a car as a Class example

Car car = new Car();

class Car{
    string Brand = "Audi";
    float Speed = 0f;
    
    List<Door> Doors;
    Door LeftFrontDoor;
    Door RightFrontDoor;

    //The constructor of the Car Class
    public Car(){
        Doors = new List<Door>();
        LeftFrontDoor = new Door();
        RightFrontDoor = new Door();
        Doors.Add(LeftFrontDoor);
        Doors.Add(RightFrontDoor);
    }

    void Accelerate(){
        Speed = Speed + 1f;
    }

    void Break(){
        Speed = 0;
    }
}



class Door{

    bool IsOpen = false;

    public void Open(){
        this.IsOpen = true;
    }

    public void Close(){
        this.IsOpen = false;
    }

}