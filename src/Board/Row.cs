namespace Game_of_Life.src.Board
{
    /**
    * #Struct: Row
    * 
    * This struct represents a game board row. Board size is
    * ten rows, each row of length ten (100 total cells).
    *
    **/

    struct Row
    {
        public char[] cells {get; set;}
        private int numOfPlayers{get; set;}

        public Row()
        {
            cells = new char[10];
        }

        public Row(int numOfPlayers)
        {
            this.numOfPlayers = numOfPlayers;
        }

    }




}