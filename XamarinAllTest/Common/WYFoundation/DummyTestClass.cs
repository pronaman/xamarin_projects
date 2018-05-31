using System;
using System.Collections.Generic;
using System.Text;
using WYFoundation.Mvvm;

namespace XamarinAllTest.Common.WYFoundation
{
    internal class DummyNoUseEventCommand : Command
    {
        public override void Begin()
        {
            _workingStatus = Status.Execute;
        }

        public override void Execute()
        {
            
        }
    }

    internal class DummyCommandEvent : CommandEvent
    {
    }

    internal class DummyEventCommand : Command
    {
        public override void Begin()
        {
        }

        public override void OnEvent(CommandEvent commandEvent)
        {
            if (commandEvent is DummyCommandEvent dummyCommandEvent)
            {
                _workingStatus = Status.Execute;
            }
        }

        public override void Execute()
        {
        }
    }
}
