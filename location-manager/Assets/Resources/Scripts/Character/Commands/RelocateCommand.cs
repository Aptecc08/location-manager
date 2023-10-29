public class RelocateCommand : ICommand
{
    private Character _character;
    public RelocateCommand(Character character)
    {
        _character = character;
    }

    public void Execute()
    {
        
    }

}
