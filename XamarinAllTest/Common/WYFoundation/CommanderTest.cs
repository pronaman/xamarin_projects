using WYFoundation.Mvvm;
using Xunit;

namespace XamarinAllTest.Common.WYFoundation
{
    public class CommanderTest
    {
        [Fact]
        public void PushCommand_NoUseEventCommand_CurrentCommandIsNull()
        {
            Commander commander = new Commander();
            Command firstCommand = new DummyNoUseEventCommand();;

            commander.PushCommand(firstCommand);
            Assert.Null(commander.CurrentCommand);
        }

        [Fact]
        public void PushCommand_EventCommand_CurrentCommandHasValue()
        {
            Commander commander = new Commander();

            Command firstCommand = new DummyEventCommand();

            commander.PushCommand(firstCommand);

            Assert.Same(firstCommand, commander.CurrentCommand);
        }

        [Fact]
        public void PushCommand_CurrentCommandExist_SecondCommandIsBlocked()
        {
            Commander commander = new Commander();

            Command firstCommand = new DummyEventCommand();
            Command secondCommand = new DummyEventCommand();

            commander.PushCommand(firstCommand);
            commander.PushCommand(secondCommand);

            Assert.Same(firstCommand, commander.CurrentCommand);
        }

        [Fact]
        public void PushCommandEvent_NoCommand_NoException()
        {
            Commander commander = new Commander();
            commander.PushCommandEvent(new CommandEvent());
        }

        [Fact]
        public void PushCommand_NoUseCommand_CommandExecuted()
        {
            Commander commander = new Commander();
            Command command = new DummyNoUseEventCommand();
            commander.PushCommand(command);

            Assert.Equal(Command.Status.Execute, command.WorkingStatus);
        }

        [Fact]
        public void PushCommand_DummyEventCommand_CommandStatusIsWorking()
        {
            Commander commander = new Commander();
            Command command = new DummyEventCommand();
            commander.PushCommand(command);
            Assert.Equal(Command.Status.Working, command.WorkingStatus);
        }

        [Fact]
        public void PushCommadEent_PushedRightEvent_CommandStatusIsExecuted()
        {
            Commander commander = new Commander();
            Command command = new DummyEventCommand();
            commander.PushCommand(command);

            commander.PushCommandEvent(new DummyCommandEvent());
            Assert.Equal(Command.Status.Execute, command.WorkingStatus);
        }
    }
}
