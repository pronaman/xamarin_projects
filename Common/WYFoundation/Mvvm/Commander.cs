namespace WYFoundation.Mvvm
{
    public class Commander
    {
        private Command _currentCommand;

        public Commander()
        {
        }

        public Command CurrentCommand { get => _currentCommand; }

        public void PushCommand(Command command)
        {
            if (_currentCommand != null)
                return;

            _currentCommand = command;
            _currentCommand.Begin();

            ProcessCommand();
        }

        private void ProcessCommand()
        {
            if (_currentCommand == null)
                return;

            switch (_currentCommand.WorkingStatus)
            {
                case Command.Status.Execute:
                    _currentCommand.Execute();
                    _currentCommand = null;
                    break;
            }
            
        }

        public void PushCommandEvent(CommandEvent commandEvent)
        {
            _currentCommand?.OnEvent(commandEvent);
        }
    }
}
