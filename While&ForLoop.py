# Jerome Reaux Jr.
# 2/18/2024
# Repeating Actions with Loops


#code is getting user's name
name = input("Hello! Thank you for joining me today. What's your name?\n")
print('Nice to meet you ' + name)

#code explaining todays prompt
print("Today we're going guess the next number in the squence then we'll move onto something diferent\n ")

#useline input, just want the user to read then respond
ready = input("Does that sound for to you? (y/n)\n")

print("Awesome!!!\n")

print("First Question:\n")
print("What would be next number to appear?\n")

#while loop that displays all numbers before 6
i = 1
while i < 6:
  print(i)
  i += 1

prom1 = input()

#if statement for prompt one
if prom1 == 6:
    print("\nGood job you got it right!!!\n")
    print("Let's move on.\n")
elif prom1 != 6:
    print("\nThe next number would be 6.\n")
    print("It's okay, let's try next one.\n")

#2nd prompt the numbers will be increasing by 10
print("What number going to appear next?\n")

i = 2
while i < 100:
  print(i)
  i += 10
  
prom2 =input()

#if statement for prompt two
if prom1 == 102:
    print("\nYou are a rockstar!!!\n")
    print("Next Question.\n")
elif prom1 != 102:
    print("\nThe next number would 102\n")
    print("Don't sweat it let's move forward.\n")
    
#User names fruit that I'll put in a for loop
print("For the next portion, I'll have you name 3 fruit\n")
print ("I'll guess what listed listed\n")

f1 = input("\n1st Fruit: ")
f2 = input("2nd Fruit: ")
f3 = input("3rd Fruit: ")

#Useless input just a breakpoint
AIcorr = input("\nDo you believe that I guess right? (y/n)")

print ("I predict that you'll say:\n")
#my for loop will take what the user says and displays it
Fruit = [f3, f2, f1]
for x in Fruit:
    print(x)

cheat = input("Was I right? (y/n)")

# If statement for if the user believes the Ai or not
if cheat == "y" or cheat == "Y" or cheat == "yes" or cheat == "Yes":
    print("\nYou're too just to predictable\n")
    print("Try again another time\n")
    print("Till next time " + name)
        
elif cheat == "n" or cheat == "N" or cheat == "no" or cheat == "No":
    print("\nImpressed you are correct!!")
    print("I didn't guess what you were going say, I cheated\n")
    print("My programmor that you were going to say:\n")
        #My for loop
    fute = ("Lemon", "Kiwi", "and Plum")
    for y in fute:
         print(y)
            
    print("\nI'm sorry I tricked you" + name)
