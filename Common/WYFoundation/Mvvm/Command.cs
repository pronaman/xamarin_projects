using System;
namespace WYFoundation.Mvvm
{
    public abstract class Command
    {
        public enum Status
        {
            Execute,
            Working
        }

        protected Status _workingStatus = Status.Working;

        public Status WorkingStatus { get => _workingStatus; }

        public abstract void Begin();

        public virtual void OnEvent(CommandEvent commandEvent) {}
        public abstract void Execute();
    }

}
