using System;

namespace Project
{
    class MenuCall
    {
	public bool menuSelection = false;
	public int selectionID = 0;
        void MenuCall()
	{
	}

	public void MenuHandle()
	{
		do
		{
		    ConsoleKey keyPress = Console.ReadKey(true).Key;
		    switch (keyPress)
		    {
			case ConsoleKey.Enter:
			    this.menuSelection = true;           
			    continue;
			case ConsoleKey.UpArrow:
			    if (selectionID == 0)
			    {
				selectionID = 2;
			    }
			    else
			    {
				--selectionID;
			    }
			    selectionMenu(selectionID);
			    continue;
			case ConsoleKey.DownArrow:
			    if (selectionID == 2)
			    {
				selectionID = 0
			    }
			    else
			    {
				++selectionID;
			    }
			    selectionMenu(selectionID);
			    continue;
			default:
			    break;
		    }
		}
		while (menuSelection = false);

		void passSelection(selectionID)
		{
		    // Write method that passess the selectionID as a parameter and forwards the game as if a new game is called and start the game
		}

		void selectionMenu(this.selectionID)
		{
		    switch (selectionID)
		    {
			case 0:
			    Console.SetCursorPosition(32, 24);
			    SetColor();
			    Console.Write(" Continue ");
			    Console.ResetColor();
			    break;
			case 1:
			    Console.SetCursorPosition(32, 26);
			    SetColor();
			    Console.Write("   Load   ");
			    Console.ResetColor();
			    break;
			case 2:
			    Console.SetCursorPosition(32, 28);
			    SetColor();
			    Console.Write(" New Game ");
			    Console.ResetColor();
			    break;
			default:
			    break;
		    }

		}

		void SetColor()
		{
		    Console.ForegroundColor = ConsoleColor.White;
		    Console.BackgroundColor = COnsoleColor.Green;
		}
	}
    }
}
