# Jerome Reaux Jr.
# 2/1/2024
# Reading and Writing Files in Python
 
 
 
#Getting user's name
while True:
    name = input("Hello, thank you for joining me today\nWhat is your name?\n")
 
    #print user's names
    print(name + "? Odd name but nonetheless, I'm happy you're here.\n")
 
    print("Here's the rundown:\nThe bad boss(Mom) had locked up the treasure(Gummies)\n")
    print("Our job is break into the vault, get the treasures.\n ")
    print("We sent in the older brother unit but he hasn't returned\n")
    print("My guess is he's deceased(Got caught stealing)")
 
    ##asking for user's input to pause the story but has no consequnce for the answer
    ready = input("Enough waiting, we move in. Are you ready?(y/n)")
 
    print("That's great, let's to the battle zone(pantry)")
    print("I see the pantry,but it's very guarded(has a pad lock)")
    print("Look you around we need that code\n")
   
       ##asking for user's input to pause the story but has no consequnce for the answer
    look = input("Let's spead out. Do you want to look in left or right?(left/right)")
 
    print("I knew you were going to say that I'm already on the opposite side\n")
    print("Look like a found something, but I can't read yet, come look\n\n")
 
    print(" The text reads:")
    #The code opens the text file
    with open('PythonTextPrint.txt') as file:
        print(file.read())
 
    print(file.close)
 
    print("That hero, his sacrifice won't go unnoticed, type in the code")
   
    code = input("")
    #If else statement to get inside the value
    if code == "2901":
        print("We're in, grab what you can get out")
        print("Let's a message to the fallen ones\n")
       
        with open('PythonTextPrint.txt', 'a') as file:
           
            #imput write to the file
            Win = input("WRITE\n")
       
            #Writing into text file
            file.write("\n\n\n" + Win + "\n\n")
    #If user gets code wrong
    elif code != 2901:
        print("You got it wrong!\n Reread the note and try again")
        print("Let's retry again, write a message of your mistake\n")
       
        with open('PythonTextPrint.txt', 'a') as file:
       
            #imput write to the file
            Fail = input("WRITE\n")
           
            #Writing into text file
            file.write("\n\n\n" + Fail + "\n\n")
       
        print("BAD ENDING!!!!")
         
       
        break