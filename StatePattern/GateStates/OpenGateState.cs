using System;

namespace StatePattern.GateStates
{
    public class OpenGateState : IGateState
    {

        public IGateState Pay()
        {
            Console.WriteLine("the gate is open you cant pay again");
            return this;
        }

        public IGateState PayOk()
        {
            Console.WriteLine("Noting");
            return this;
        }

        public IGateState PayFailed()
        {
            Console.WriteLine("Noting");
            return this;
        }

        public IGateState Enter()
        {
            Console.WriteLine("User entering and gate is closing");
            return new ClosedGateState();
        }
    }
}
