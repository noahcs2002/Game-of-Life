namespace Game_of_Life.src.Board
{
    /**
    * #Struct: Player
    * 
    * This struct represents a game player. Each player
    * Can occupy a cell. The player is an I if they are 
    * infected, and a C if they are clean
    *
    **/

    struct Player
    {
        public char status{get; set;}
    }
}