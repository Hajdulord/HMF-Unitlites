namespace HMF.HMFUtilities.DesignPatterns.StatePattern
{
    public interface IState
    {
        void Tick();
        void OnEnter();
        void OnExit();
    }
}

