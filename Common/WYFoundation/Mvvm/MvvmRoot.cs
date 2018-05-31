using System;
using System.Collections.Generic;

namespace WYFoundation.Mvvm
{
    public class MvvmRoot
    {
        List<Commander> _commanderList = new List<Commander>();
        public MvvmRoot()
        {
        }

        public bool IsExistCommander(Commander commander)
        {
            return _commanderList.Contains(commander);
        }

        public void PushCommandEvent(CommandEvent commandEvent)
        {
            foreach (Commander commander in _commanderList)
                commander.PushCommandEvent(commandEvent);
        }

        public bool RegisterCommander(Commander commander)
        {
            if (IsExistCommander(commander))
                return false;
            
            _commanderList.Add(commander);
            return true;
        }
    }
}
