public class Car
{
    // properties
    public String Model { get; set; }
    public String Make { get; set; }
    public int CurrentSpeed { get; private set; }
    public bool EnginRunning { get; private set; }

    public void StartEngin()
    {
        EnginRunning = true;
    }

    public void StopEngin()
    {
        EnginRunning = false;
    }

    public void Accelerate()
    {
        if ( !EnginRunning )
        {
            throw new Exception( "Cannot accelerate because the engin is not running. Please use StartEngin() first.");
        }
        if ( CurrentSpeed > 200)
        {
            CurrentSpeed = 200;
        }
        CurrentSpeed += 10;
    }

    public void Decelerate()
    {
        if ( CurrentSpeed < 0)
        {
            CurrentSpeed = 0;
        }
        CurrentSpeed -= 10;
    }
    
}