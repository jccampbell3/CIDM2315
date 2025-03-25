using System;
namespace ExtraCredit;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("****Rock Paper Scissors, Start!!****");
        
        HumanPlayer player1 = new HumanPlayer(10);
        ComputerPlayer comp = new ComputerPlayer(10);
        string input = "y";

        do {
            Console.WriteLine("You have "+ player1.getPoints()+ " points");
            Console.WriteLine("Please input your choice: rock, paper, or scissors.");
            player1.currentMove = Console.ReadLine();
            Console.WriteLine("--> Your decision: " + player1.HumanDecision());
            Console.WriteLine("--> Computers decision: " + comp.ComputerDecision());
            PlayGame(player1, comp);

            if(CheckPoints(player1)) {
                Console.WriteLine("Sorry, you don't have any more points, you lose. Thanks for playing.");
                break;
            }
            else if(CheckPoints(comp)) {
                Console.WriteLine("You win! Computer ran out of points. Thanks for playing!");
                break;
            }
            else {
               Console.WriteLine("--> Play again? Input y to continue, or n to exit."); 
               input = Console.ReadLine();
            }
        } while(input == "y");

    }
    
    static bool CheckPoints(HumanPlayer p1) {
        if(p1.getPoints() == 0) return true;
        else return false;

    }
    static bool CheckPoints(ComputerPlayer p1) {
        if(p1.getPoints() == 0) return true;
        else return false;
    }
    static void PlayGame(HumanPlayer p1, ComputerPlayer p2) {
        if(p1.currentMove == p2.currentMove) {
            Console.WriteLine("It's a tie!");
            return;
        }
        
        switch(p1.currentMove) {
            case "rock":
                if(p2.currentMove == "scissors") {
                    Console.WriteLine("You win!");
                    p1.WinRound();
                    p2.LostRound();
                    break;
                }
                else {
                    Console.WriteLine("You Lost!");
                    p1.LoseRound();
                    p2.WinRound();
                    break;
                }

            case "scissors":
                if(p2.currentMove == "rock") {
                    Console.WriteLine("You Lost!");
                    p1.LoseRound();
                    p2.WinRound();
                    break;
                }
                else {
                    Console.WriteLine("You win!");
                    p1.WinRound();
                    p2.LostRound();
                    break;
                }
            case "paper":
                if(p2.currentMove == "rock") {
                    Console.WriteLine("You win!");
                    p1.WinRound();
                    p2.LostRound();
                    break;
                }   
                else {
                    Console.WriteLine("You Lost!");
                    p1.LoseRound();
                    p2.WinRound();
                    break;
                } 

        }

    }

}
class HumanPlayer {
    private int points = 0;
    public string currentMove = "";
    public HumanPlayer(int initial) { points = initial; }
    public int getPoints() { return points; }
    public void WinRound() { points += 5; }
    public void LoseRound() { points -= 5; }
    public string HumanDecision() { return currentMove; }

}

class ComputerPlayer {
    private int points = 0;
    public string currentMove = "";
    public ComputerPlayer(int initial) { points = initial; }
    public int getPoints() { return points; }
    public void WinRound() { points += 5; }
    public void LostRound() { points -= 5; }
    public string ComputerDecision() {
        Random rnd = new Random();
        int rnd_num = rnd.Next(0,3);
        switch(rnd_num) {
            case 0:
                currentMove = "rock";
                return currentMove;
            case 1:
                currentMove = "paper";
                return currentMove;
            case 2:
                currentMove = "scissors";
                return currentMove;        
            default:
                return "error";
        }
        
    }

}