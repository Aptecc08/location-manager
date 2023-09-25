using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandController : MonoBehaviour
{
    public static CommandController Instance { get; set; }

    private Queue<ICommand> _commandsBuffer = new Queue<ICommand>();

    private void Awake()
    {
        if (Instance != null) return;
        else Instance = this;
    }

    public void Update()
    {
        GetAndExecuteNextCommand();
    }

    public CommandController AddCommand(ICommand command)
    {
        _commandsBuffer.Enqueue(command);
        return this;
    }

    private void GetAndExecuteNextCommand()
    {
        //if (isPaused) return;
        if (_commandsBuffer.Count == 0) return;

        ICommand command = _commandsBuffer.Dequeue();
        command.Execute();
    }
}
