internal class Program
{
    // Давайте играть! Вы должны вернуть, какой игрок выиграл! В случае ничьей ответный розыгрыш!
    // Пример:
    // "scissors", "paper" => "Player 1 won!"
    // "scissors", "rock" => "Player 2 wond!"
    // "paper", "paper" => "Draw!"
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public string RPS(string player1, string player2)
    {
        if (player1 == player2)
            return "Draw!";

        if (((player1 == "rock") && (player2 == "scissors")) ||
            ((player1 == "scissors") && (player2 == "paper")) ||
            ((player1 == "paper") && (player2 == "rock")))
        {
            return "Player 1 won!";
        }
        else
        {
            return "Player 2 won!";
        }
    }
}