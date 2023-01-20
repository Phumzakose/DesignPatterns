using CommandDesign;

Document doc = new Document();

ICommand openCommand = new OpenCommand(doc);
ICommand saveCommand = new SaveCommand(doc);
ICommand closeCommand = new CloseCommand(doc);

MenuOptions menu = new MenuOptions(openCommand, saveCommand, closeCommand);

menu.ClickOpen();
menu.ClickSave();
menu.ClickClose();
