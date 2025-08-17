// Jerome Reaux Jr.
//  File I/O (Input and Output)
// 2-15-2024

#include <iostream>
#include <string>
#include <fstream>

using namespace std;

string password;
string rd;
string ready;
string RES;
string write;

// My display that will happen outside of main
void intro(){
    cout << "Hello sacred traveler, where we've been excepting you\n";
    cout << "Speaking the magic password to continue\n";
    //There's no magic word, the user can put anything
    cin >> password;
}

int main()
{
    intro();
    
    cout << "\nIt truly is you, I'd thought I'll never see the day.\n";
    cout << "The day of fable door being opened\n";
    
    cout << "Do you need a rundown? (y/n)\n";
    cin >> rd;
    
    // The user can choose they want to hear the story or not
    if (rd == "y" || rd == "Y") {
        cout << "\nLong ago, The Evil Queen Rose sealed away all of the happiness from this world\n";
        cout << "She said far down the timeline a child of profecy will be born to this the tablet\n";
        cout << "Upon reading the tablet they will know how to break the seal.\n";
        
    } else if (rd == "n" || rd == "N") {
        cout << "\nGood I didn't feel like explaining\n";
        cout << "Read the tablet and break the seal\n";
    }
    
    // Just a pause point for the user to read before more code
    cout << "\n\nSimple enough huh?\n";
    cout << "Are you ready to read the tablet\n";
    cin >> ready;
    
    // 
    ifstream file;
    // Code opens the text file
    file.open("TabletSeal.txt");
    // Added error checking while keeping your style
    if (!file) {
        cout << "ERROR: The tablet is missing!\n";
        return 1;
    }
    
    cout << file.good();
    // code reads the text file
    string line;
    while(file.good()) {
        getline(file, line);
        
        // Code displays the text file
        cout << line;
    }
    file.close();
    
    cout << "\n\nNow that you've read it\n";
    cout << "Please put in the code and restore the world\n";
    cin >> RES;  // CRITICAL FIX: Actually capturing user input now
    
    // Open file for writing (appending)
    ofstream outFile("TabletSeal.txt", ios::app);
    if (!outFile) {
        cout << "ERROR: Cannot update the tablet!\n";
        return 1;
    }
    
    if (RES == "esor" || RES == "ESOR" || RES == "Esor"){
        cout << "Thank you!!!\n";
        cout << "Your unselfish deed\n restored the kingdom\n";
        cout << "Please write on the tablet\n";
        cin.ignore(); // Clear buffer
        getline(cin, write);
        outFile << "\nHero's Note: " << write << "\n";  // Proper file writing
    } else{
        cout << "NO!!!!\n";
        cout << "YOU FAILED, NOW IT'S LOCK AWAY FOREVER\n";
        
        cout << "Write of the failure for the next generation\n";
        cin.ignore();
        getline(cin, write);
        outFile << "\nWarning: " << write << " (Seal reinforced)\n";  // Proper file writing
    }
    outFile.close();
    
    return 0;
}