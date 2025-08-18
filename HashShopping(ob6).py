# Jerome Reaux Jr.
# Assignment 11.1 
# 3/31/2024

print("Hello Shopper, I'm the chat bot Erie.")
name = input("Who am I shopping today?\n")
print("Awesome!!! You can look in your cart and add any amount of soda, chips, or candy you desire")
print("Happy Shopping " + name)


# Menu options
def display_menu():
    print("\nMenu:")
    print("1. Display Cart Items")
    print("2. Add to Cart")
    print("3. *Leave the store*")


# Function to display inventory using a dictionary (hash table)
def display_inventory_dict():
    print("\nYour Cart:")
    for item, quantity in inventory_dict.items():
        print(f"{item}: {quantity}")


# Function to add items to inventory
def add_to_inventory_dict():
    item = input("Enter the item name: ").lower()
    quantity = int(input("Enter the quantity: "))

    # If item already exists, update it
    if item in inventory_dict:
        inventory_dict[item] += quantity
    else:
        inventory_dict[item] = quantity

    print(f"\n{quantity} {item}(s) added to inventory.")


# inventory using dictionary (hash table)
inventory_dict = {
    "soda": 0,
    "chips": 0,
    "candy": 0
}


# Main function to run the program
def main():
    while True:
        display_menu()
        choice = input("\nEnter your choice: ")
        if choice == '1':
            display_inventory_dict()
        elif choice == '2':
            add_to_inventory_dict()
        elif choice == '3':
            print("\nThank you for shopping at UAT-Market")
            print("Have a good day " + name)
            break
        else:
            print("\nInvalid choice. Please enter a valid option.")


# Run the program
if __name__ == "__main__":
    main()
