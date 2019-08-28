using System;

namespace StatePattern.GateStates
{
    public class ClosedGateState : IGateState
    {

        public IGateState Pay()
        {
            Console.WriteLine("Gate closed, going into processing");
            return new ProcessingGateState();
        }

        public IGateState PayOk()
        {
            Console.WriteLine("Noting can happen");
            return this;
        }

        public IGateState PayFailed()
        {
            Console.WriteLine("Noting can happen");
            return this;
        }

        public IGateState Enter()
        {
            Console.WriteLine("You cant enter the gate is closed you need to pay");
            return this;
        }
    }
}
