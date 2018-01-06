using System;

namespace Command
{
    public class CommandFactory
    {
        private static CommandFactory _Instance;
        private static readonly object MyLock = new object();
        private CommandFactory() { }

        public static CommandFactory Instance
        {
            get
            {
                lock(MyLock)
                {
                    if(_Instance == null)
                    {
                        _Instance = new CommandFactory(); 
                    }
                }
                return _Instance;
            }
        }

        public Invoker Invoker { get; set; }

        public virtual void CreateAndDo(string commandType, params object[] commandParameters)  //commandParameters is option and can be replace with a delegate
        {
            Command command = null;

            switch (commandType.Trim().ToUpper())
            {
                case "SKILL":
                    //command = new AttackCommand(commandParamters);
                    break;
            }

            if (command != null)
            {
                Invoker.EnqueueCommandForExecution(command);
            }
        }
    }
}
