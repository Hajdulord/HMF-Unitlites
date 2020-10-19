using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HMF.HMFUtilities.DesignPatterns.CommandPattern
{
    public class CommandProcessor
    {
        private List<Command> _commands = new List<Command>();
        private int _currentCommandIndex = - 1;
    

        public void ExecuteCommand(Command command)
        {
            _commands.Add(command);
            command.Execute();
            _currentCommandIndex = _commands.Count - 1;
        }

        public void Redo()
        {
            if (_currentCommandIndex < 0) 
                return;

            Command redoCommand = _commands[_currentCommandIndex];
            redoCommand.Execute();

            _commands.Add(redoCommand);
            _currentCommandIndex++;
        }

        public void Undo()
        {
            if (_currentCommandIndex < 0) 
                return;

            _commands[_currentCommandIndex].Undo();
            _commands.RemoveAt(_currentCommandIndex);
            _currentCommandIndex--;
        }
    }
}