namespace StatePattern.GateStates
{
    public interface IGateState
    {

       IGateState Pay();
       IGateState PayOk();
       IGateState PayFailed();
       IGateState Enter();
    }
}
