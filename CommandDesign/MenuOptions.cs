namespace CommandDesign;

public class MenuOptions
{
  private ICommand openCommand;
  private ICommand saveCommand;
  private ICommand closeCommand;


  public MenuOptions(ICommand openCommand, ICommand saveCommand, ICommand closeCommand)
  {
    this.openCommand = openCommand;
    this.saveCommand = saveCommand;
    this.closeCommand = closeCommand;
  }

  public void ClickOpen()
  {
    openCommand.Execute();
  }

  public void ClickSave()
  {
    saveCommand.Execute();
  }

  public void ClickClose()
  {
    closeCommand.Execute();
  }
}