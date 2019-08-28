using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.GateStates;

namespace StatePattern
{
    public class Gate
    {
        private IGateState state;

        public Gate()
        {
            this.state = new ClosedGateState();
        }

        public void ChangeState(IGateState newState)
        {
            this.state = newState;
        }

        public void Pay()
        {
           this.state = this.state.Pay();
        }

        public void PayOk()
        {
            this.state = this.state.PayOk();
        }

        public void PayFailed()
        {
           this.state = this.state.PayFailed();
        }

        public void Enter()
        {
            this.state = this.state.Enter();
        }
    }
}
