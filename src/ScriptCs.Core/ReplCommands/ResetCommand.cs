﻿using ScriptCs.Contracts;

namespace ScriptCs.ReplCommands
{
    public class ResetCommand : IReplCommand
    {
        public string CommandName
        {
            get { return "reset"; }
        }

        public object Execute(IScriptExecutor repl, object[] args)
        {
            Guard.AgainstNullArgument("repl", repl);

            repl.Reset();
            return null;
        }
    }
}