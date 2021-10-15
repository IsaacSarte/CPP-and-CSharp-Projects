#include <iostream>    
#include <ctime> 
#include <windows.h>   
#include <stdlib.h>
#include <conio.h>
#include <cstdlib> 
#include <iomanip>
#include <string>
#include <fstream>


#define ROW 0
#define COLUMN 1

using namespace std;

// Ordinary Chess by CS127-8L //
// Team Members: [Sarte, Isaac],[Navarro, Francheska],[Mendoza, Marichella],[Masacayan, AJ] //


void clearScreen(); // Clear Screen Function
void introduceGame(); // Instructions Function

int roll(); // Dice Function

/*
	Board Function
*/
typedef struct Board
{
	char position[8][8];
} Board;

void inititalizeBoard(Board* chessBoard);
void updateBlock(Board* chessBoard, int pos[], char value);
char getBlockValue(Board chessBoard, int pos[]);
void makeMove(Board* chessBoard, int from[], int to[]);
void printBoard(Board chessBoard);

/*
	Players Function
*/
typedef struct Player
{
	int initialPosition[2];
	char pieceType[6];
} Player;

int* piecePosition(Player player);
char* getPieceType(Player player);
bool isValid(Player player, Board board);
void pickPiece(Player* player, Board board);

/*
	Pieces Function
*/
typedef struct Piece
{
	char pieceName[7];
	char pieceType[6];
	int playerWon;
	int currentPosition[2];
	int finalPosition[2];
	bool validMove;
} Piece;

void newPiece(Piece* piece, char name, char* type, Player player1, Player player2);
void isKingCaptured(Piece* piece, Board chessBoard);
void movePiece(Piece* piece, Board chessBoard);
void changePawn(Piece piece, Board* chessBoard);
void movePawn(Piece* piece, Board chessBoard);
void moveRook(Piece* piece, Board chessBoard);
void moveHorse(Piece* piece, Board chessBoard);
void moveBishop(Piece* piece, Board chessBoard);
void moveQueen(Piece* piece, Board chessBoard);
void moveKing(Piece* piece);
int determineMove(Piece* piece, Board* chessBoard);

/*
	Highscore Function
*/
struct highscore
{
	string name;
	int score;
} highscores;

void getHS();

//Global Variables
string p1Name; 
string p2Name;
int p1Score;
int p2Score;
int playerWon;

string pname;
int pscore = 0;

char retrn = true;
char choice2 = 'N';
char choice3;

int main()
{

	Piece chessPiece;

	Player player1, player2;
	strcpy(player1.pieceType, "white");
	strcpy(player2.pieceType, "black");

	Board chessBoard;
	bool isInt = false;

	srand((unsigned)time(0));
	Beep(440, 300); Sleep(50);
	cout << "L";
	Beep(587, 300); Sleep(50);
	cout << "O";
	Beep(740, 300); Sleep(50);
	cout << "A";
	Beep(784, 300); Sleep(50);
	cout << "D";
	Beep(740, 300); Sleep(50);
	cout << "I";
	Beep(587, 300); Sleep(50);
	cout << "N";
	Beep(440, 300); Sleep(50);
	cout << "G";
	Beep(392, 300); Sleep(50);
	cout << ".";
	Beep(587, 300); Sleep(50);
	cout << ".";
	Beep(554, 1200); Sleep(1200);
	cout << ".";

	int choice, p1turn, p2turn;
	do
	{
		clearScreen();

		cout << "--------ORDINARY CHESS GAME--------" << endl
			<< "\t [1] New Game" << endl
			<< "\t [2] Tutorial" << endl
			<< "\t [3] See LeaderBoard" << endl
			<< "\t [4] Close to Desktop" << endl
			<< "\t Enter your choice: ";
		cin >> choice;
		isInt = cin.fail();
		if (isInt)
		{
			cout << "Exception is Caught! Choice must be a numeric value." << endl;
			Sleep(1000);
			cin.clear();
			cin.ignore(5, '\n');
		}

		switch (choice)
		{
		case 1:
		{
			Sleep(500);
			clearScreen();

			string filename = "HighScore.txt"; //Text file for highscores
			ofstream outFile;

			outFile.open(filename.c_str(), ios::app); //Opening file for appending

			if (outFile.fail())
			{
				cout << "Cannot Open Text File!" << endl
					<< "Please check if the file currently exists." << endl;
				exit(1);
			}

			p1Name = "", p2Name = "";
			p1Score = 0, p2Score = 0;

			cout << "Enter Player 1's Name: "; //Player 1's Name
			cin.ignore();
			getline(cin, p1Name);

			cout << "Enter Player 2's Name: "; //Player 2's Name
			getline(cin, p2Name);

			system("CLS");

			do // Play Again?
			{
				cout << "Generating Chess Board";
				for (int dot = 0; dot < 3; dot++)
				{
					cout << ".";
					Sleep(1000);
				}
				Beep(50, 1000); Sleep(100);

				clearScreen();

				inititalizeBoard(&chessBoard);
				while (true)
				{
					do
					{
						for (int i = 0; i < 3; i++)
						{
							cout << "\\"; Sleep(500); system("CLS");
							cout << "|"; Sleep(500); system("CLS");
							cout << "/"; Sleep(500); system("CLS");
						}

						cout << "WHITE ROLLED: ";
						p1turn = roll();
						cout << p1turn << endl;
						Sleep(2000);

						cout << "BLACK ROLLED: ";
						p2turn = roll();
						cout << p2turn << endl;
						Sleep(2000);


					} while (p1turn == p2turn);
					Sleep(1000);
					if (p1turn > p2turn)
					{
						system("mode 80"); //Change screen size
						clearScreen();
						printBoard(chessBoard);
						pickPiece(&player1, chessBoard);
						newPiece(&chessPiece, getBlockValue(chessBoard, piecePosition(player1)), //Position of the piece selected by the player
							getPieceType(player1), player1, player2);

						playerWon = determineMove(&chessPiece, &chessBoard);
						if (playerWon == 1)
						{
							system("mode 80");
							printBoard(chessBoard);
							p1Score++;
							cout << "Player 1 has won the game!" << endl;
							system("pause");
							break;
						}
					}
					else if (p2turn > p1turn)
					{
						system("mode 80");
						clearScreen();
						printBoard(chessBoard);
						pickPiece(&player2, chessBoard);
						newPiece(&chessPiece, getBlockValue(chessBoard, piecePosition(player2)),
							getPieceType(player2), player1, player2);

						playerWon = determineMove(&chessPiece, &chessBoard);
						if (playerWon == 2)
						{
							system("mode 80");
							printBoard(chessBoard);
							p2Score++;
							cout << "Player 2 has won the game!" << endl;
							system("pause");
							break;
						}
					}
				}
				cout << "Press any key to play again or [N/n] to quit to main menu. ";
				cin >> choice2;
				choice2 = toupper(choice2);
				if (choice2 == 'N' || choice2 == 'n')
				{
					if (p1Score > 0)
					{
						pname = p1Name;
						pscore = p1Score;
						outFile << pname << "\t" << pscore << endl;
					}
					else if (p2Score > 0)
					{
						pname = p2Name;
						pscore = p2Score;
						outFile << pname << "\t" << pscore << endl << endl;
					}
					
					system("CLS");
					break;
				}
			} while (choice2 != 'N');

			outFile.close();
			cin.ignore();
			break;
		}
		case 2:
			Sleep(500);
			introduceGame();
			clearScreen();
			break;

		case 3:
			Sleep(500);
			getHS();
			clearScreen();
			break;

		case 4:
			Sleep(500);
			clearScreen();

			Beep(440, 300); Sleep(50);
			cout << "G";
			Beep(392, 300); Sleep(50);
			cout << "O";
			Beep(740, 300); Sleep(50);
			cout << "O";
			Beep(740, 300); Sleep(50);
			cout << "D";
			Beep(784, 300); Sleep(50);
			cout << "B";
			Beep(659, 300); Sleep(50);
			cout << "Y";
			Beep(587, 300); Sleep(50);
			cout << "E";
			Beep(587, 300); Sleep(50);
			cout << "!";
			Beep(554, 300); Sleep(50);
			cout << "!";
			Beep(587, 1500); Sleep(50);
			cout << "!" << endl << endl;
			cout << "Exiting program...";
			Beep(50, 1500); Sleep(500);

			return 0;
			break;

		default:
			cout << "Invalid Input! Choice must be [1],[2],[3] ONLY." << endl;
			Sleep(1000);
			break;
			return 0;
		}
	} while (retrn = true);//choice != 3);
	return 0;
}

void clearScreen()
{
	system("CLS"); // Here is the body
}

void introduceGame()
{
	clearScreen();

	cout << "\t\tFirst things first..." << endl;
	Sleep(5000);
	cout << "\t\tA game of chess is a game of two players" << endl;
	Sleep(5000);
	cout << "\t\tTwo players with both great minds" << endl;
	Sleep(5000);
	cout << "\t\tBut what if..." << endl;
	Sleep(2000);
	Beep(500, 500); Sleep(10);
	Beep(400, 1000); Sleep(3000);
	cout << "\t\tLuck is needed, luck is maybe with you";
	Sleep(3000);
	cout << " or luck is not with you" << endl;
	Sleep(2000);

	clearScreen();

	Beep(300, 1000);
	cout << "    ___________________________________________" << endl;
	cout << "\tThis ";
	Beep(300, 1000);
	cout << "is ";
	Beep(400, 2000);
	cout << "ORDINARY CHESS by CS127-8L" << endl;
	cout << "    ___________________________________________" << endl << endl;
	system("pause");

	clearScreen();

	cout << "This game follows the rules behind Chess" << endl; Sleep(200);
	cout << "Player 1 plays as WHITE. Player 2 plays as BLACK" << endl << endl; Sleep(200);
	cout << "Here are the keys to know which is which:" << endl; Sleep(200);
	cout << "Player 1 - [small letters]" << endl
		<< "Player 2 - [capital letters]" << endl << endl; Sleep(500);
	cout << "-------------------------------------------------------------" << endl;
	cout << "Chess have Pieces and here is how each player move the Pieces" << endl << endl;
	cout << "Player 1 : PAWN - [p] | Player 2 : PAWN - [P]" << endl
		<< "           ROOK - [r] |            ROOK - [R]" << endl
		<< "           HORSE- [h] |            HORSE- [H]" << endl
		<< "           BISHOP-[b] |            BISHOP-[B]" << endl
		<< "           QUEEN- [q] |            QUEEN- [Q]" << endl
		<< "           KING - [k] |            KING - [K]" << endl;
	cout << "-------------------------------------------------------------" << endl;
	system("pause");
	cout << endl;
	cout << "Here is the CATCH of the game!: " << endl; Sleep(200);
	cout << "There will be a Dice Roll for Player 1 and also for Player 2" << endl; Sleep(200);
	cout << "The Player who got the biggest number of rolled dice will be the player to move a piece" << endl; Sleep(200);
	cout << "The process given above is repeated althrough each move" << endl; Sleep(200);
	cout << "A game with only ONE player is moving a piece is possible ;)!!!" << endl; Sleep(2000);
	cout << "You'll later find out the other obstacles in the game ;)" << endl; Sleep(2000);
	cout << "Luck is maybe with you, or is luck not with you" << endl; Sleep(2000);
	cout << "This is Ordinary Chess"; Sleep(2000);
	Beep(50, 1500); Sleep(500);
	cout << endl;
	system("pause");
}

int roll()
{
	return (rand() % 6) + 1; 
}

/*
	Board Function Bodies
*/
void inititalizeBoard(Board* chessBoard)
{
	//Positioning pieces for Player2
	chessBoard->position[0][0] = chessBoard->position[0][7] = 'R'; //Rook
	chessBoard->position[0][1] = chessBoard->position[0][6] = 'H'; //Horse
	chessBoard->position[0][2] = chessBoard->position[0][5] = 'B'; //Bishop
	chessBoard->position[0][3] = 'K'; //King
	chessBoard->position[0][4] = 'Q'; //Queen
	for (int i = 0; i < 8; i++)
		chessBoard->position[1][i] = 'P'; //Pawns

	//Positioning pieces for Player1
	chessBoard->position[7][0] = chessBoard->position[7][7] = 'r';
	chessBoard->position[7][1] = chessBoard->position[7][6] = 'h';
	chessBoard->position[7][2] = chessBoard->position[7][5] = 'b';
	chessBoard->position[7][3] = 'k';
	chessBoard->position[7][4] = 'q';
	for (int i = 0; i < 8; i++)
		chessBoard->position[6][i] = 'p';

	//Filling empty spaces
	for (int i = 2; i < 6; i++)
		for (int j = 0; j < 8; j++)
			chessBoard->position[i][j] = ' ';
}

void updateBlock(Board* chessBoard, int pos[], char value)
{
	chessBoard->position[pos[ROW]][pos[COLUMN]] = value;
}

char getBlockValue(Board chessBoard, int pos[])
{
	return chessBoard.position[pos[ROW]][pos[COLUMN]];
}

void makeMove(Board* chessBoard, int from[], int to[])
{
	char name = getBlockValue(*chessBoard, to), pieceLost[7];
	if (name == ' ')
		strcpy(pieceLost, "NULL");
	if (name == 'P' || name == 'p')
		strcpy(pieceLost, "Pawn");
	else if (name == 'R' || name == 'r')
		strcpy(pieceLost, "Rook");
	else if (name == 'H' || name == 'h')
		strcpy(pieceLost, "Horse");
	else if (name == 'B' || name == 'b')
		strcpy(pieceLost, "Bishop");
	else if (name == 'Q' || name == 'q')
		strcpy(pieceLost, "Queen");
	else if (name == 'K' || name == 'k')
		strcpy(pieceLost, "King");

	if (strcmp(pieceLost, "NULL") != 0)
	{
		cout << "Opponent lost a " << pieceLost << endl;
		system("pause");
	}

	chessBoard->position[to[ROW]][to[COLUMN]] = chessBoard->position[from[ROW]][from[COLUMN]];
	chessBoard->position[from[ROW]][from[COLUMN]] = ' ';
}

void printBoard(Board chessBoard)
{
	char rowNumber = 'a', columnNumber = '1';
	cout << "   ";
	for (int i = 0; i < 8; i++)
		cout << "       " << columnNumber++;
	cout << endl;
	for (int i = 0; i <= 8; i++)
	{
		cout << "   ";
		for (int j = 0; j < 9; j++)
			cout << "   #    ";
		cout << endl;
		cout << "   ";
		for (int j = 0; j < 71; j++)
			cout << "#";
		cout << endl;
		cout << "   ";
		for (int j = 0; j < 9; j++)
			cout << "   #    ";
		cout << endl;
		if (i != 8)
		{
			cout << rowNumber++ << "  ";
			for (int j = 0; j < 8; j++)
				cout << "   #   " << chessBoard.position[i][j];
			cout << "   #    ";
			cout << endl;
		}
	}
	cout << "    ";
}

/*
	Pieces Function Bodies
*/
void newPiece(Piece* piece, char name, char* type, Player player1, Player player2)
{
	if (name == 'P' || name == 'p')
		strcpy(piece->pieceName, "Pawn");
	else if (name == 'R' || name == 'r')
		strcpy(piece->pieceName, "Rook");
	else if (name == 'H' || name == 'h')
		strcpy(piece->pieceName, "Horse");
	else if (name == 'B' || name == 'b')
		strcpy(piece->pieceName, "Bishop");
	else if (name == 'Q' || name == 'q')
		strcpy(piece->pieceName, "Queen");
	else if (name == 'K' || name == 'k')
		strcpy(piece->pieceName, "King");

	strcpy(piece->pieceType, type);

	if (strcmp(piece->pieceType, "white") == 0)
	{
		piece->currentPosition[0] = piecePosition(player1)[0];
		piece->currentPosition[1] = piecePosition(player1)[1];
	}
	else
	{
		piece->currentPosition[0] = piecePosition(player2)[0];
		piece->currentPosition[1] = piecePosition(player2)[1];
	}

	piece->validMove = true;
}

void isKingCaptured(Piece* piece, Board chessBoard)
{
	if (getBlockValue(chessBoard, piece->finalPosition) == 'k')  //White king is captured
		piece->playerWon = 2;
	else if (getBlockValue(chessBoard, piece->finalPosition) == 'K') //Black king is captured
		piece->playerWon = 1;
	else
		piece->playerWon = 0;
}

void movePiece(Piece* piece, Board chessBoard)
{
	char block[3];
	do
	{
		cout << "Move " << piece->pieceName << " to: ";
		cin >> block;
		piece->finalPosition[ROW] = block[ROW] - 97; //Assigning numerical equivalent of the row indicator
		piece->finalPosition[COLUMN] = block[COLUMN] - 49; // Assigning one less than the numerical equivalent of the column indicator because positions start form zero
		if (piece->finalPosition[ROW] < 0 || piece->finalPosition[ROW] > 7 || piece->finalPosition[COLUMN] < 0 || piece->finalPosition[COLUMN] > 7)
		{
			cout << "Selected block do not exist!" << endl;
			piece->validMove = false;
		}
		else if ((strcmp(piece->pieceType, "white") == 0 && islower(getBlockValue(chessBoard, piece->finalPosition)))       //Same player's piece is
			|| (strcmp(piece->pieceType, "black") == 0 && isupper(getBlockValue(chessBoard, piece->finalPosition))))   //present at the drop point
		{
			cout << "Your piece is present at that location! ";
			piece->validMove = false;
		}
		else
			piece->validMove = true;
	} while (piece->validMove == false);
}

void changePawn(Piece piece, Board* chessBoard)
{
	char choice, changeWith; int flag;
	cout << "Select a piece to replace your pawn:" << endl;
	cout << "1. Queen" << endl;
	cout << "2. Rook" << endl;
	cout << "3. Horse" << endl;
	cout << "4. Bishop" << endl;
	do
	{
		cout << "Enter your choice: ";
		cin >> &choice;
		flag = 1;
		switch (choice)
		{
		case '1': changeWith = 'q'; break;
		case '2': changeWith = 'r'; break;
		case '3': changeWith = 'h'; break;
		case '4': changeWith = 'b'; break;
		default: cout << "Invalid choice! Please chose again..."; flag = 0;
		}
	} while (flag == 0);
	if (strcmp(piece.pieceType, "black") == 0)
		updateBlock(chessBoard, piece.currentPosition, toupper(changeWith));
	else
		updateBlock(chessBoard, piece.currentPosition, changeWith);
}

void movePawn(Piece* piece, Board chessBoard)
{
	if (strcmp(piece->pieceType, "white") == 0 && piece->finalPosition[ROW] != piece->currentPosition[ROW] - 1) //White pawns move upwards
	{
		cout << "Pawn can only move forward! ";
		piece->validMove = false;
	}
	else if (strcmp(piece->pieceType, "black") == 0 && piece->finalPosition[ROW] != piece->currentPosition[ROW] + 1) //Black pawns move downwards
	{
		cout << "Pawn can only move forward! ";
		piece->validMove = false;
	}
	if (piece->validMove == true)
	{
		if (piece->finalPosition[COLUMN] == piece->currentPosition[COLUMN] //Pawn remains in the same column, moves one step forward
			&& !isalpha(getBlockValue(chessBoard, piece->finalPosition))) //Front block is empty
			piece->validMove = true;
		else if ((piece->finalPosition[COLUMN] == piece->currentPosition[COLUMN] + 1 || piece->finalPosition[COLUMN] == piece->currentPosition[COLUMN] - 1) //Pawn is moving diagonally, one column to the left or the right
			&& isalpha(getBlockValue(chessBoard, piece->finalPosition))) //Chess piece is present at that block
			piece->validMove = true;
		else
		{
			cout << "Pawn can only move one step at a time! ";
			piece->validMove = false;
		}
	}
}

void moveRook(Piece* piece, Board chessBoard)
{
	int tempPosition[2];
	if (piece->finalPosition[ROW] == piece->currentPosition[ROW]) //Rook is moving along the row
	{
		tempPosition[ROW] = piece->currentPosition[ROW];
		if (piece->finalPosition[COLUMN] > piece->currentPosition[COLUMN]) //Rook is moving upward
			for (int col = piece->currentPosition[COLUMN] + 1; col < piece->finalPosition[COLUMN]; col++) //Looping between the current position and final position
			{
				tempPosition[COLUMN] = col;
				if (isalpha(getBlockValue(chessBoard, tempPosition))) //Checking if a chess piece is present
				{
					cout << "Path is blocked by a piece! ";
					piece->validMove = false;
					break;
				}
			}
		else if (piece->finalPosition[COLUMN] < piece->currentPosition[COLUMN]) //Rook is moving downward
			for (int col = piece->currentPosition[COLUMN] - 1; col > piece->finalPosition[COLUMN]; col--)
			{
				tempPosition[COLUMN] = col;
				if (isalpha(getBlockValue(chessBoard, tempPosition)))
				{
					cout << "Path is blocked by a piece! ";
					piece->validMove = false;
					break;
				}
			}
		else
			piece->validMove = true;
	}
	else if (piece->finalPosition[COLUMN] == piece->currentPosition[COLUMN]) //Rook is moving along the column
	{
		tempPosition[COLUMN] = piece->currentPosition[COLUMN];
		if (piece->finalPosition[ROW] > piece->currentPosition[ROW]) //Rook is moving towards right
			for (int row = piece->currentPosition[ROW] + 1; row < piece->finalPosition[ROW]; row++)
			{
				tempPosition[ROW] = row;
				if (isalpha(getBlockValue(chessBoard, tempPosition)))
				{
					cout << "Path is blocked by a piece! ";
					piece->validMove = false;
					break;
				}
			}
		else if (piece->finalPosition[ROW] < piece->currentPosition[ROW]) //Rook is moving towards left
			for (int row = piece->currentPosition[ROW] - 1; row > piece->finalPosition[ROW]; row--)
			{
				tempPosition[ROW] = row;
				if (isalpha(getBlockValue(chessBoard, tempPosition)))
				{
					cout << "Path is blocked by a piece! ";
					piece->validMove = false;
					break;
				}
			}
		else
			piece->validMove = true;
	}
	else
		piece->validMove = false;
}

void moveHorse(Piece* piece, Board chessBoard)
{
	if ((piece->currentPosition[ROW] == piece->finalPosition[ROW] - 2 || piece->currentPosition[ROW] == piece->finalPosition[ROW] + 2)                  //Two steps up OR two steps down
		&& (piece->currentPosition[COLUMN] == piece->finalPosition[COLUMN] - 1 || piece->currentPosition[COLUMN] == piece->finalPosition[COLUMN] + 1)) //One step to the right OR one step to the left

		piece->validMove = true;

	else if ((piece->currentPosition[COLUMN] == piece->finalPosition[COLUMN] - 2 || piece->currentPosition[COLUMN] == piece->finalPosition[COLUMN] + 2)    //Two steps right OR two steps left
		&& (piece->currentPosition[ROW] == piece->finalPosition[ROW] - 1 || piece->currentPosition[COLUMN] == piece->finalPosition[COLUMN] + 1))       //One step up OR one step down

		piece->validMove = true;

	else
		piece->validMove = false;

	if (piece->validMove == false)
		cout << "Horse can\'t move that way! ";
}

void moveBishop(Piece* piece, Board chessBoard)
{
	//Bishop moves in diagonal lines so I decided to code this imagining a cartesian plane with 4 quadrants in it
	piece->validMove = false;

	if (piece->finalPosition[ROW] > piece->currentPosition[ROW] && piece->finalPosition[COLUMN] > piece->currentPosition[COLUMN]) //First quadrant
	{
		for (int tempPosition[] = { piece->currentPosition[ROW] + 1, piece->currentPosition[COLUMN] + 1 }; tempPosition[ROW] < 8, tempPosition[COLUMN] < 8; //Starts from the front-right block 
			tempPosition[ROW]++, tempPosition[COLUMN]++) //Until end of board is reached and checks the blocks diagonally [Upward Right]
		{
			if (piece->finalPosition[ROW] == tempPosition[ROW] && piece->finalPosition[COLUMN] == tempPosition[COLUMN]) //Block found
			{
				piece->validMove = true;
				break;
			}
			else if (isalpha(getBlockValue(chessBoard, tempPosition)))
			{
				cout << "Path is blocked by a piece! ";
				piece->validMove = false;
				break;
			}
		}
	}
	else if (piece->finalPosition[ROW] > piece->currentPosition[ROW] && piece->finalPosition[COLUMN] < piece->currentPosition[COLUMN]) //Second quadrant
	{
		for (int tempPosition[] = { piece->currentPosition[ROW] + 1, piece->currentPosition[COLUMN] - 1 }; tempPosition[ROW] < 8, tempPosition[COLUMN] > -1; //Starts from front-left block
			tempPosition[ROW]++, tempPosition[COLUMN]--) //Checks the blocks diagonally [upward left]
		{
			if (piece->finalPosition[ROW] == tempPosition[ROW] && piece->finalPosition[COLUMN] == tempPosition[COLUMN]) //Block found
			{
				piece->validMove = true;
				break;
			}
			else if (isalpha(getBlockValue(chessBoard, tempPosition)))
			{
				cout << "Path is blocked by a piece! ";
				piece->validMove = false;
				break;
			}
		}
	}
	else if (piece->finalPosition[ROW] < piece->currentPosition[ROW] && piece->finalPosition[COLUMN] < piece->currentPosition[COLUMN]) //Third quadrant
	{
		for (int tempPosition[] = { piece->currentPosition[ROW] - 1, piece->currentPosition[COLUMN] - 1 }; tempPosition[ROW] > -1, tempPosition[COLUMN] > -1; //Starts from down-left block
			tempPosition[ROW]--, tempPosition[COLUMN]--) //Checks the blocks diagonally [downward left]
		{
			if (piece->finalPosition[ROW] == tempPosition[ROW] && piece->finalPosition[COLUMN] == tempPosition[COLUMN]) //Block found
			{
				piece->validMove = true;
				break;
			}
			else if (isalpha(getBlockValue(chessBoard, tempPosition)))
			{
				cout << "Path is blocked by a piece! ";
				piece->validMove = false;
				break;
			}
		}
	}
	else if (piece->finalPosition[ROW] < piece->currentPosition[ROW] && piece->finalPosition[COLUMN] > piece->currentPosition[COLUMN]) //Fourth quadrant
	{
		for (int tempPosition[] = { piece->currentPosition[ROW] - 1, piece->currentPosition[COLUMN] + 1 }; tempPosition[ROW] > -1, tempPosition[COLUMN] < 8; //Starts from down-right block
			tempPosition[ROW]--, tempPosition[COLUMN]++) //Checks the blocks diagonally [downward right]
		{
			if (piece->finalPosition[ROW] == tempPosition[ROW] && piece->finalPosition[COLUMN] == tempPosition[COLUMN]) //Block found
			{
				piece->validMove = true;
				break;
			}
			else if (isalpha(getBlockValue(chessBoard, tempPosition)))
			{
				cout << "Path is blocked by a piece! ";
				piece->validMove = false;
				break;
			}
		}
	}
	if (piece->validMove == false)
	{
		cout << "Bishop can't be moved there! ";
	}
}

void moveQueen(Piece* piece, Board chessBoard)
{
	//Queen either moves straight or diagonally
	if (piece->finalPosition[ROW] == piece->currentPosition[ROW] || piece->finalPosition[COLUMN] == piece->currentPosition[COLUMN]) //Queen moves straight in either direction
		moveRook(piece, chessBoard);       //Follows the same algorithm required for the Rook
	else
		moveBishop(piece, chessBoard);     //If not moving straight, must move diagonally like Bishop
}

void moveKing(Piece* piece)
{
	if (piece->finalPosition[ROW] == piece->currentPosition[ROW] + 1 || piece->finalPosition[ROW] == piece->currentPosition[ROW] - 1                 //Moving only one step forward or one step backward
		|| piece->finalPosition[COLUMN] == piece->currentPosition[COLUMN] + 1 || piece->finalPosition[COLUMN] == piece->currentPosition[COLUMN] - 1) //Or moving only one step left or one step right
	{
		piece->validMove = true;
	}
	else
	{
		cout << "King can't move that way! ";
		piece->validMove = false;
	}
}

int determineMove(Piece* piece, Board* chessBoard)
{
	do
	{
		movePiece(piece, *chessBoard);
		system("pause");
		if (strcmp(piece->pieceName, "Pawn") == 0)
			movePawn(piece, *chessBoard);
		else if (strcmp(piece->pieceName, "Rook") == 0)
			moveRook(piece, *chessBoard);
		else if (strcmp(piece->pieceName, "Horse") == 0)
			moveHorse(piece, *chessBoard);
		else if (strcmp(piece->pieceName, "Bishop") == 0)
			moveBishop(piece, *chessBoard);
		else if (strcmp(piece->pieceName, "Queen") == 0)
			moveQueen(piece, *chessBoard);
		else if (strcmp(piece->pieceName, "King") == 0)
			moveKing(piece);
	} while (!piece->validMove);

	if (strcmp(piece->pieceName, "Pawn") == 0 && (piece->finalPosition[ROW] == 0 || piece->finalPosition[ROW] == 7)) //Special case for Pawn when it reaches the opposite side of the chess board
		changePawn(*piece, chessBoard); //Change pawn to desired piece

	isKingCaptured(piece, *chessBoard);

	makeMove(chessBoard, piece->currentPosition, piece->finalPosition);
	return piece->playerWon;
}

/*
	Players Function Bodies
*/
int* piecePosition(Player player)
{
	return player.initialPosition;
}

char* getPieceType(Player player)
{
	return player.pieceType;
}

bool isValid(Player player, Board board)
{
	char selectedBlock = getBlockValue(board, player.initialPosition);

	if (player.initialPosition[0] < 0 || player.initialPosition[0] > 7 || player.initialPosition[1] < 0 || player.initialPosition[1] > 7) {
		cout << "Selected block do not exist!";
		return false;
	}
	else if (selectedBlock == ' ')
	{
		cout << "Selected block is empty";
		return false;
	}
	else if ((strcmp(getPieceType(player), "white") == 0 && isupper(selectedBlock)) || (strcmp(getPieceType(player), "black") == 0 && islower(selectedBlock)))
	{
		cout << "Selected block doesn\'t belong to the current player!";
		return false;
	}

	return true;
}

void pickPiece(Player* player, Board board)
{
	char block[3];
	do
	{
		int playerNumber = strcmp(player->pieceType, "white") == 0 ? 1 : 2; //Check if player1 or player2 is there
		cout << endl << "Player " << playerNumber << " pick a piece: ";
		cin >> block;
		player->initialPosition[ROW] = block[ROW] - 97; //Assigning numerical equivalent of the row indicator
		player->initialPosition[COLUMN] = block[COLUMN] - 49; // Assigning one less than the numerical equivalent of the column indicator because positions start form zero
	} while (!isValid(*player, board));
}

/*
	Highscore Function Bodies
*/
void sortHS(highscore* hs, int array_size)
{
	for (int i = 0; i < array_size; i++)
	{
		for (int j = 0; j < i; j++)
		{
			highscore* hs1 = &hs[i];
			highscore* hs2 = &hs[j];
			if (hs1->score > hs2->score)
			{
				highscore temp = *hs1;
				*hs1 = *hs2;
				*hs2 = temp;
			}
		}
	}
}

void getHS()
{
	string filename = "HighScore.txt";
	ifstream inFile;

	inFile.open(filename.c_str());

	if (inFile.fail())
	{
		cout << "Cannot Open Data/Text File!" << endl
			<< "Please check if the file currently exists." << endl;
		exit(1);
	}

	highscore* hs = NULL;

	int pass = 0;
	int count = 0;
	int index = 0;
	while (pass < 2)
	{
		pname = "";
		pscore = -1;

		inFile >> pname >> pscore;

		if (pass == 0) 
		{
			if (pname != "") count++;
		}
		else if (pass == 1)
		{
			if (pname != "")
			{
				if (hs)
				{
					hs[index].name = pname;
					hs[index++].score = pscore;
				}
			}
		}
		if (inFile.eof())
		{
			if (count > 0 && !hs)
				hs = new highscore[count];

			inFile.clear();
			inFile.seekg(0, ios::beg);
			pass++;
		}
	}

	sortHS(hs, count);

	cout << endl << "-------------------- LEADERBOARD --------------------" << endl;
	cout << "Name: " << "\t\t\t\t\tScore: " << endl << endl;

	for (int i = 0; i < count; i++)
	{
		highscore currentHS = hs[i];

		cout << setiosflags(ios::left) << setw(25) << currentHS.name << "\t\t\t" << currentHS.score << endl;
	}

	cout << endl << "Press any key to quit to main menu: ";
	cin >> choice3;

	inFile.close();
	cin.ignore();
}
