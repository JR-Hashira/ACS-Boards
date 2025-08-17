// Jerome Reaux Jr.
// 2/6/2024
// Object Oriented Programming II


#include <iostream>
#include <string>

using namespace std;

// My display
void Intro() {
    cout << "Hello to the Great Ninja vs Pirate War!\n";
    cout << "We need you to pick the winning side\n";
}

// GameStructure class
class GameStructure {
public:

    virtual void Help() const = 0; 
};

 // The class with the specifer and variables
class Character:public GameStructure {
    
    // public class properties
public:
    string name;
    int age;

     // private class properties
private:
    int hp;

public:
    // Getter for hp
    int getHealth() const {
        return hp;
    }

    // Setter for hp
    void setHealth(int health) {
        // Ensuring that the health is never negative
        if (health >= 0) {
            hp = health;
        } else {
            cout << "Error: Health cannot be negative.\n";
        }
    }

     // Talk method
    void Speak(string speech) {
        cout << name << ": " << speech;
    }

    // Virtual attack method
    virtual int attack() const {
         // Base attack value
        return 10; 
    }   
    // Help method override
    void Help() const override {
        cout << "I'll aid your group in this war\n";
    }

};



// Pirate Inheritance Class from Character class
class Pirate : public Character {
public:
    void UseCannon() {
        cout << "She's gonna blow!!!\n";
    }

    void printHealth() const {
        cout << "Health: " << getHealth() << endl;
    }
    
    // Override attack method
    int attack() const override {
        // attack value for pirate character
        return 25;
    }
    
     // Help method override
    void Help() const override {
        cout << "\n\nWith the cannon your hand you yelled:\n";
        cout << "For the pirate bargade!\n";
        cout << "She's gonna blow!!!\n";
        cout << "proceeding to let out a great deal of destruction\n";
    }
};

// Ninja Inheritance Class from Character class
class Ninja : public Character {
public:
  
    void printHealth() const {
        cout << "Health: " << getHealth() << endl;
    }
      // Override attack method
    int attack() const override {
        // attack value for ninja character
        return 25;
    }
    
     // Help method override
    void Help() const override {
        cout << "\n\nRunning into battle you yelled:\n";
        cout << "For the ninja class!\n";
        cout << "Fire Style: Fireball Jutsu!!\n";
        cout << "proceeding to let out a great deal of destruction\n";
    }
};

string role;

   


int main() {
    
     // Calling my display from outside the main
    Intro();

   // Object for the Character class
    Character player;

// access to attrictubes of the class
    cout << "\n\nBefore we get started, what is your name?\n";
    cin >> player.name;

    cout << player.name;
    cout << " huh? Lastly, what is your age?\n";
    cin >> player.age;

    cout << "\n\nWhich side will you aid in the war? (Ninja/Pirate)\n";
    cin >> role;

    // creating new Inheritance to call for which class the user picks
      Character* chosenSide;
      
     
      
// If player chooses team Ninja
    if (role == "Ninja" || role == "ninja") {
           chosenSide = new Ninja();
           chosenSide->Help();
           int power = chosenSide->attack();
           cout << "\nEradicating " << power << " damage to everyone!";
      
    } 
     // If player chooses Team Pirate
    else if (role == "Pirate" || role == "pirate") {
           chosenSide = new Pirate();
           chosenSide->Help();
       int power = chosenSide->attack();
      
      cout << "\nEradicating " << power << " damage to everyone!";
    } 
    
    // Player doesn't choose a team
    else {
        cout << "Since you chose not to interfere, both teams take each other out\n";
    }
   
    


    cout << "\n\nYou see no more standing";

    return 0;
}
