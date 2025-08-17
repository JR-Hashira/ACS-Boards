// Jerome Reaux Jr.
// Assignment 3.3: Mars Base Energy Grid Simulator in Java with Variables and Arrays
     
    // Allows user's input
    import java.util.Scanner;
    
    public class EnergyOutputCalculator {
    
    public static void main(String[] args) {
        
        System.out.println("Welcome Back Traveler!!\nHow are you doing?");
     
        Scanner check = new Scanner(System.in);
        System.out.print("\n ");
        String input = check.nextLine();
     
        System.out.println("\nAhh I see\nI mean you are stuck on a space station so makes sense.");
        System.out.println("I'm standing Idle. Would you like to help me with rebooting my systems?\n");
        
        System.out.print("(y/n): ");
        String response = check.nextLine(); 

        // Check the user's response
        if (response.equalsIgnoreCase("y")) {
            System.out.println("Awesome let's get started!");
        } else {
            System.out.println("I understand, I'll probably overwhelm you :((");
            // ends code if user says no 
            System.exit(0);
        }
        
        System.out.println("I need to get my systems running\n");
         System.out.println("Flip the switches when I tell you to\n");
        System.out.println("\n");
        
        
        // arrays with just building up like uploading something
        // (these will exceed 100)
        int[] Power = {1, 33, 41, 69, 80, 95, 100};
        int[] Guards = {2, 34, 49, 60, 100};

        // My variables that calculate the 
        int BackupPower = calculateTotalEnergy(Power);
        int SecurityManagement = calculateTotalEnergy(Guards);
        // The sum of my two variables
        int totalEnergy = BackupPower + SecurityManagement;

        System.out.println("Firstly, I'll have you turn on my power");
        System.out.print("Flip? (y/n): ");
        String Light = check.nextLine();
        System.out.println("System starting with 1, now 33, now 41, now 69. \nThe systems back is now at: " + BackupPower +"\n");
     
      
        System.out.println("Now, I'll have you reset my Security systems");
        System.out.print("Flip? (y/n): ");
        String Badge = check.nextLine();
        System.out.println("System protected measures resetting now 1, now 33, now 41, now 69. \nThe systems back is now at: " + SecurityManagement);
        
        // Power is in Megawatts
        System.out.println("Systems are up and running with : " + totalEnergy + " MW");
        System.out.println("Thank you for your help today");
    }

    // Method to calculate the total energy from an array
    public static int calculateTotalEnergy(int[] energyArray) {
        int total = 0;
        for (int energy : energyArray) {
            total += energy;
        }
        return total;
    }
}
