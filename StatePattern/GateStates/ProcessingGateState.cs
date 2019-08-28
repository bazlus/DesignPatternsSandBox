using System;

namespace StatePattern.GateStates
{
    public class ProcessingGateState : IGateState
    {
        public IGateState Pay()
        {
            Console.WriteLine("You cant pay again we are still processing");
            return this;
        }

        public IGateState PayOk()
        {
            Console.WriteLine("Payment is successful gate is open");
            return new OpenGateState();
        }

        public IGateState PayFailed()
        {
            Console.WriteLine("Payment not successful gate still closed");
            return new ClosedGateState();
        }

        public IGateState Enter()
        {
            Console.WriteLine("You cant enter we are still processing");
            return this;
        }
    }
}
