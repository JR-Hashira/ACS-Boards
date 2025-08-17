using System;

namespace StudentAndGameSystem
{
    class Program
    {
        // Student System Arrays
        static string[] studentNames = new string[0];
        static double[][] studentGrades = new double[0][];

        // Tic-Tac-Toe Board Array
        static char[,] ticTacToeBoard = new char[3, 3];

        static void Main(string[] args)
        {
            Console.WriteLine("Dual System: Student Grades + Tic-Tac-Toe");

            // Initialize the board
            InitializeBoard();

            while (true)
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Student System");
                Console.WriteLine("2. Tic-Tac-Toe Game");
                Console.WriteLine("3. Exit");
                Console.Write("Select option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        StudentMenu();
                        break;
                    case "2":
                        PlayTicTacToe();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }

        static void InitializeBoard()
        {
            // Initialize empty board
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    ticTacToeBoard[i, j] = ' ';

            // Starting positions
            ticTacToeBoard[0, 0] = 'X';
            ticTacToeBoard[1, 1] = 'O';
        }

        static void StudentMenu()
        {
            while (true)
            {
                Console.WriteLine("\nStudent System:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Back to Main");
                Console.Write("Select option: ");

                string choice = Console.ReadLine();
                if (choice == "1") AddStudent();
                else if (choice == "2") DisplayStudents();
                else if (choice == "3") break;
                else Console.WriteLine("Invalid option!");
            }
        }

        static void AddStudent()
        {
            Console.Write("\nEnter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter grades (comma separated): ");
            string[] gradeInputs = Console.ReadLine().Split(',');
            double[] grades = new double[gradeInputs.Length];

            for (int i = 0; i < gradeInputs.Length; i++)
            {
                if (!double.TryParse(gradeInputs[i].Trim(), out grades[i]))
                {
                    Console.WriteLine($"Invalid grade: {gradeInputs[i]}");
                    return;
                }
            }

            Array.Resize(ref studentNames, studentNames.Length + 1);
            Array.Resize(ref studentGrades, studentGrades.Length + 1);

            studentNames[studentNames.Length - 1] = name;
            studentGrades[studentGrades.Length - 1] = grades;

            Console.WriteLine("Student added!");
        }

        static void DisplayStudents()
        {
            if (studentNames.Length == 0)
            {
                Console.WriteLine("No students yet!");
                return;
            }

            Console.WriteLine("\nStudent Records:");
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine($"{studentNames[i]}: {string.Join(", ", studentGrades[i])}");
            }
        }

        static void PlayTicTacToe()
        {
            char currentPlayer = 'X'; // Start with X

            while (true)
            {
                Console.WriteLine("\nCurrent Tic-Tac-Toe Board:");
                PrintBoard();

                // Move input
                Console.WriteLine($"Player {currentPlayer}'s turn");
                Console.Write("Enter row (0-2): ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Enter column (0-2): ");
                int col = int.Parse(Console.ReadLine());

                // Validate move
                if (row < 0 || row > 2 || col < 0 || col > 2)
                {
                    Console.WriteLine("Invalid position! Use 0-2.");
                    continue;
                }
                if (ticTacToeBoard[row, col] != ' ')
                {
                    Console.WriteLine("Position already taken!");
                    continue;
                }

                // Place the mark
                ticTacToeBoard[row, col] = currentPlayer;

                // Switch player
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';

                // Exit option
                Console.WriteLine("Press Enter to continue or 'Q' to quit...");
                if (Console.ReadLine().ToUpper() == "Q") break;
            }

            // Reset board
            InitializeBoard();
        }

        static void PrintBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(ticTacToeBoard[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
