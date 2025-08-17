// Jerome Reaux Jr
// Assignment 6.3: Mars expedition - Arrays and Random Number Generators

import java.util.Random;
import java.util.Scanner;

public class RoomService {
    public static void main(String[] args) {
           // Create a Scanner object
        Scanner scanner = new Scanner(System.in);

        // Prompt for the user's name
        System.out.println("Oh, you're the new name commander. Remind me of your name:");
        
        // Read the input
        String name = scanner.nextLine();

        // Print a greeting
        System.out.println("Yes, commander " + name + "\n\n");
        
        System.out.println("Your job is assign rooms to your recuits");
        System.out.println("At the end, I'll give access code to go enter each room");
        
        System.out.println("Would you like to proceed with the room assignments? (yes/no)");
        String response = scanner.nextLine().trim().toLowerCase();
        
       if (response.equals("yes")) {
            // Proceed with room assignments
            System.out.println("Great!! Let's continue");
        } else {
            // exit code
            System.out.println("Okay, commander " + name + ". Exiting the program. :)");
        }
        
        // Close the scanner
        scanner.close();
        
        // Hard-coded array of crew member names
        String[] crewMembers = {
            "Diana P.",
            "Bobby D.",
            "Bruce W.",
            "David E.",
            "Eva J.",
            "Richard G.",
            "Clark K.",
            "Hannah M.",
            "Isaac O.",
            "Jack V."
        };

        // Hard-coded array of room numbers
        String[] roomNumbers = {
            "The Asylum (Room 1)",
            "The Pizzaria (Room 2)",
            "The Cave (Room 3)",
            "The Museum (Room 4)",
            "The Resturant (Room 5)",
            "The Space Shuttle (Room 6)",
            "The Classroom (Room 7)",
            "The Mansion (Room 8)",
            "The Bunker (Room 9)",
            "The Beach House (Room 10)"
        };

        // Create an instance of Random for generating the security code
        Random random = new Random();
        // Generate a random security code (6-digit number)
        int securityCode = 100000 + random.nextInt(900000);

         // Shuffle the crew members for random assignments
        for (int i = 0; i < crewMembers.length; i++) {
            int randomIndex = random.nextInt(crewMembers.length);
            // Swap crew members
            String temp = crewMembers[i];
            crewMembers[i] = crewMembers[randomIndex];
            crewMembers[randomIndex] = temp;
        }

        // Display the room assignments
        System.out.println("Room Assignments:");
        for (int i = 0; i < roomNumbers.length; i++) {
            System.out.println(roomNumbers[i] + " belongs to " + crewMembers[i]  + "\n");
        
        }

        // Display the random security code
        System.out.println("\nAs promised for your good job the security code is: " + securityCode);
    }
}
