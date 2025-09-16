namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bulb = new Bulb();

            var turnOnCommand = new TurnOn(bulb);
            var turnOffCommand = new TurnOff(bulb);

            var remoteControl = new RemoteControl();
            remoteControl.Submit(turnOnCommand);
            remoteControl.Submit(turnOffCommand);
        }
    }
}
