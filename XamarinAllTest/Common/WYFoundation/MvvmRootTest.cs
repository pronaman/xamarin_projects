using System;
using WYFoundation.Mvvm;
using Xunit;

namespace XamarinAllTest.Common.WYFoundation
{
    public class MvvmRootTest
    {
        private readonly MvvmRoot _root = new MvvmRoot();
        private readonly Commander _commander = new Commander();

        public MvvmRootTest()
        {
            _root.RegisterCommander(_commander);
        }

        /// <summary>
        /// Registers the commander add new commander success to add.
        /// </summary>
        [Fact]
        public void RegisterCommander_AddNewCommander_SuccessToAdd()
        {
            Assert.True(_root.IsExistCommander(_commander));
        }

        [Fact]
        public void RegisterCommander_TrySameNewCommander_FailToAdd()
        {
            _root.RegisterCommander(_commander);
            Assert.False(_root.RegisterCommander(_commander));
        }
    }
}
