public class Car
{

    public String Model;
    public String Make;
    public int CurrentSpeed;
    public bool EnginRunning;
    
    public void startEngin()
    {
        EnginRunning = true;
    }

    public void stopEngin()
    {
        EnginRunning = false;
    }

    public void accelerate(int speed)
    {
        if (EnginRunning)
            CurrentSpeed += speed;
        else
            Console.WriteLine("The car is stopped");
    }

    public void decelarate(int speed)
    {
        if (EnginRunning)
            CurrentSpeed -= speed;
        else
            Console.WriteLine("The car is stopped");
    }
}