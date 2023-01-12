using System.Data.Common;
using System.Drawing;//ALLOWS YOU ACCESS DIFFERENT LIBRARIES
namespace Checkers_Board_Evaluation {
    internal class Program {
        //THIS IS AN EXAMPLE OF A GLOBAL CONSTANT. THIS MEANS YOU CAN USE IT ANYWHERE AND IT WON'T CHANGE.
        //ALWAYS PUT GLOBAL CONSTANTS IN "class" NOT MAIN
        //GENERAL NOTES: F1 & function and highlight and that will give you the definition of something and how to fix it
        const int height = 6;
        const int width = 12;
        const int checkerHeight = 2;
        const int checkerWidth = 2;
       
        static void Main(string[] args) {

           //ORIGINALLY I WANTED TO ONLY FILL IN THE RED TILES SINCE THE CONSOLE IS ALREADY BLACK AND THEREFORE I WOULDN'T HAVE TO MAKE BLACK TILES. I DECIDED AGAINST THIS BUT IF I WERE TO DO IT THAT WAY I WOULD HAVE TO DO THE FOLLOWING:
          //Console.BackgroundColor = ConsoleColor.White;
          //Console.ForegroundColor = ConsoleColor.Black;
          // Console.Clear();

            Console.WriteLine("LET'S PLAY CHECKERS:)");

            int[,] checkerPiece = new int[8, 8];
            checkerPiece[0, 0] = 1;
            checkerPiece[1, 0] = 2;

                    //POSITION OF THE BOARD (X, Y COORDINATES REPRESENTED BY variables xPosition & yPosition)
                    DrawBoard(4,2);
                    DisplayCheckersOnBoard(checkerPiece);
           
            //ADD CONSOLE.READKEY OR CONSOLE.WRITELINE TO REMOVE "DEBUGGING" MESSAGE AT THE END OF PROGRAM
            Console.ReadKey();
        }//END MAIN

        static void DrawBoard(int xPosition, int yPosition) {

            ConsoleColor green = ConsoleColor.Green;
            ConsoleColor red = ConsoleColor.DarkRed;
            //ROW 1 
            //          4       +   8    * 0 = xPosition is(or rather starts) in coordinate 4, yPosition starts at y coordinate 2
            DrawSquare(xPosition + width * 0,yPosition + height * 0, width, height, red); //USE CTRL & D TO DUPLICATE LINE
            DrawSquare(xPosition + width * 1,yPosition + height * 0, width, height, green);
            DrawSquare(xPosition + width * 2,yPosition + height * 0, width, height, red);
            DrawSquare(xPosition + width * 3,yPosition + height * 0, width, height, green);
            DrawSquare(xPosition + width * 4,yPosition + height * 0, width, height, red);
            DrawSquare(xPosition + width * 5,yPosition + height * 0, width, height, green);
            DrawSquare(xPosition + width * 6,yPosition + height * 0, width, height, red);
            DrawSquare(xPosition + width * 7,yPosition + height * 0, width, height, green);
           
           //ROW 2 
            DrawSquare(xPosition + width * 0,yPosition + height * 1, width, height, green);
            DrawSquare(xPosition + width * 1,yPosition + height * 1, width, height, red);
            DrawSquare(xPosition + width * 2,yPosition + height * 1, width, height, green);
            DrawSquare(xPosition + width * 3,yPosition + height * 1, width, height, red);
            DrawSquare(xPosition + width * 4,yPosition + height * 1, width, height, green);
            DrawSquare(xPosition + width * 5,yPosition + height * 1, width, height, red);
            DrawSquare(xPosition + width * 6,yPosition + height * 1, width, height, green);
            DrawSquare(xPosition + width * 7,yPosition + height * 1, width, height, red);

            //ROW 3
            DrawSquare(xPosition + width * 0, yPosition + height * 2, width, height, red);
            DrawSquare(xPosition + width * 1, yPosition + height * 2, width, height, green);
            DrawSquare(xPosition + width * 2, yPosition + height * 2, width, height, red);
            DrawSquare(xPosition + width * 3, yPosition + height * 2, width, height, green);
            DrawSquare(xPosition + width * 4, yPosition + height * 2, width, height, red);
            DrawSquare(xPosition + width * 5, yPosition + height * 2, width, height, green);
            DrawSquare(xPosition + width * 6, yPosition + height * 2, width, height, red);
            DrawSquare(xPosition + width * 7, yPosition + height * 2, width, height, green);

            //ROW 4
            DrawSquare(xPosition + width * 0, yPosition + height * 3, width, height, green);
            DrawSquare(xPosition + width * 1, yPosition + height * 3, width, height, red);
            DrawSquare(xPosition + width * 2, yPosition + height * 3, width, height, green);
            DrawSquare(xPosition + width * 3, yPosition + height * 3, width, height, red);
            DrawSquare(xPosition + width * 4, yPosition + height * 3, width, height, green);
            DrawSquare(xPosition + width * 5, yPosition + height * 3, width, height, red);
            DrawSquare(xPosition + width * 6, yPosition + height * 3, width, height, green);
            DrawSquare(xPosition + width * 7, yPosition + height * 3, width, height, red);
          
           //ROW 5
            DrawSquare(xPosition + width * 0, yPosition + height * 4, width, height, red);
            DrawSquare(xPosition + width * 1, yPosition + height * 4, width, height, green);
            DrawSquare(xPosition + width * 2, yPosition + height * 4, width, height, red);
            DrawSquare(xPosition + width * 3, yPosition + height * 4, width, height, green);
            DrawSquare(xPosition + width * 4, yPosition + height * 4, width, height, red);
            DrawSquare(xPosition + width * 5, yPosition + height * 4, width, height, green);
            DrawSquare(xPosition + width * 6, yPosition + height * 4, width, height, red);
            DrawSquare(xPosition + width * 7, yPosition + height * 4, width, height, green);

            //ROW 6
            DrawSquare(xPosition + width * 0, yPosition + height * 5, width, height, green);
            DrawSquare(xPosition + width * 1, yPosition + height * 5, width, height, red);
            DrawSquare(xPosition + width * 2, yPosition + height * 5, width, height, green);
            DrawSquare(xPosition + width * 3, yPosition + height * 5, width, height, red);
            DrawSquare(xPosition + width * 4, yPosition + height * 5, width, height, green);
            DrawSquare(xPosition + width * 5, yPosition + height * 5, width, height, red);
            DrawSquare(xPosition + width * 6, yPosition + height * 5, width, height, green);
            DrawSquare(xPosition + width * 7, yPosition + height * 5, width, height, red);

            //ROW 7
            DrawSquare(xPosition + width * 0, yPosition + height * 6, width, height, red);
            DrawSquare(xPosition + width * 1, yPosition + height * 6, width, height, green);
            DrawSquare(xPosition + width * 2, yPosition + height * 6, width, height, red);
            DrawSquare(xPosition + width * 3, yPosition + height * 6, width, height, green);
            DrawSquare(xPosition + width * 4, yPosition + height * 6, width, height, red);
            DrawSquare(xPosition + width * 5, yPosition + height * 6, width, height, green);
            DrawSquare(xPosition + width * 6, yPosition + height * 6, width, height, red);
            DrawSquare(xPosition + width * 7, yPosition + height * 6, width, height, green);

            //ROW 8
            DrawSquare(xPosition + width * 0, yPosition + height * 7, width, height, green);
            DrawSquare(xPosition + width * 1, yPosition + height * 7, width, height, red);
            DrawSquare(xPosition + width * 2, yPosition + height * 7, width, height, green);
            DrawSquare(xPosition + width * 3, yPosition + height * 7, width, height, red);
            DrawSquare(xPosition + width * 4, yPosition + height * 7, width, height, green);
            DrawSquare(xPosition + width * 5, yPosition + height * 7, width, height, red);
            DrawSquare(xPosition + width * 6, yPosition + height * 7, width, height, green);
            DrawSquare(xPosition + width * 7, yPosition + height * 7, width, height, red);

            //Was going to do it like this first however making height,width,& the x & y coordinates into their own variables makes it a lot more malleable
            //DrawSquare(8, 3, 4, 2, red);
            //DrawSquare(4, 5, 4, 2, red);
            //DrawSquare(8, 7, 4, 2, red);
            //DrawSquare(4, 9, 4, 2, red);
            //DrawSquare(8, 11, 4, 2, red);
            //DrawSquare(4, 13, 4, 2, red);


        }//END DRAWBOARD FUNCTION

        static void DrawSquare(int xPos, int yPos, int width, int height,ConsoleColor color) { 
            int startX = xPos;
            int startY = yPos;
            int endX = xPos + width;
            int endY = yPos + height;

            for (int xPlot = startX; xPlot < endX; xPlot++) {
                for (int yPlot = startY; yPlot < endY; yPlot++) {
                    SetBlock(xPlot, yPlot, color);
                }//END SECOND FOR LOOP
            }//END FIRST FOR LOOP
        
        }//END DRAW SQUARE FUNCTION
        static void SetBlock(int xPos, int yPos, ConsoleColor color) {
            //STORE OLD COLORS
            //ConsoleColor origForeground = Console.ForegroundColor;
            //ConsoleColor origBackground = Console.BackgroundColor;

            //SET BLOCK COLOR. THIS MAKES THE SYMBOL (!) AND IT'S BACKGROUND THE SAME COLOR SO IT LOOKS LIKE A TILE/SQUARE
            Console.ForegroundColor = color;
            Console.BackgroundColor = color;
            Console.BufferHeight = 1000;
            //I DIDN'T HAVE THIS ORIGINALLY AND IT CAUSED THE PROGRAM TO CRASH. TO FIND OUT BUFFERSIZE CONSOLE.WRITELINE(BUFFERHEIGHT);

            //MOVE CURSOR TO POSITION
            Console.SetCursorPosition(xPos, yPos);
            

            //DRAW BLOCK
            Console.Write("!");

            //CHANGE COLORS BACK
            //Console.ForegroundColor = origForeground;
            //Console.BackgroundColor = origBackground;
        }//end SETBLOCK Function

        static void DrawCheckerPiece( int xPos, int yPos, int width, int height, ConsoleColor color) {//CHANGE THIS TO TAKE OUT XPOS AND YPOS
           
            int startX = xPos;
            int startY = yPos;
            int endX = xPos + width; 
            int endY = yPos + height;

            for (int xPlot = startX; xPlot < endX; xPlot++) {
                for (int yPlot = startY; yPlot < endY; yPlot++) {
                    SetChecker(xPlot, yPlot, color);
                }//END SECOND FOR LOOP
            }//END FIRST FOR LOOP


        }//end DrawCheckerPiece Function
        static void DisplayCheckersOnBoard(int[,] board, int xPos, int yPos) {
            for (int column = 0; column < board.GetLength(0); column++) {
                for (int row = 0; row < board.GetLength(1); row++) { 
                  
                
                }//end second for loop
            
            }//end first for loop
            int checkerPiece = board[column, row];
            ConsoleColor yellow = ConsoleColor.Black;
            DrawCheckerPiece( 5, 5, checkerWidth, checkerHeight, yellow);//CHANGE THIS TO TAKE OUT

        }//end DisplayCheckersOnBoard Function
        static void SetChecker(int xPos, int yPos, ConsoleColor color) {
            //STORE OLD COLORS
            //ConsoleColor origForeground = Console.ForegroundColor;
            //ConsoleColor origBackground = Console.BackgroundColor;

            //SET BLOCK COLOR. THIS MAKES THE SYMBOL (!) AND IT'S BACKGROUND THE SAME COLOR SO IT LOOKS LIKE A TILE/SQUARE
            Console.ForegroundColor = color;
            Console.BackgroundColor = color;

            //MOVE CURSOR TO POSITION
            Console.SetCursorPosition(xPos, yPos);

            //DRAW BLOCK
            Console.Write("(      )");

            //CHANGE COLORS BACK
            //Console.ForegroundColor = origForeground;
            //Console.BackgroundColor = origBackground;
        }//end SETBLOCK Function
    }//END CLASS
}//END NAMESPACE