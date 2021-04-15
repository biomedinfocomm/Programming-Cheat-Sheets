# Addition
10 + 10
20

# Add and print
print(10 +10)
20

a = "North"
print(a)

# Printing values stored in variable
total = 10 + 10
(total)
20

# Update a variable must already store a value
+=, -=, *=, /=, **=

a = 10
a += 10
a = 10 + 10
print(a)
20

# Convert to round down
round(10.2)
10

# Convert to round up
round(10.88)
11

# Find type of variables
type("colour")
str

# Concatenating two or more string
colours = "red" + " " + "green"
print(colours)
red green

# Find length of the locations
locations = ["North", "South", "East", "West"]
print (len(locations))
4

# Find positive index of the locations
locations = ["North", "South", "East", "West"]
print(locations[2])
East

# Find negative index of the locations
locations = ["North", "South", "East", "West"]
print(locations[-1])
West

# List slicing of the locations
locations = ["North", "South", "East", "West"]
print(locations[1:3])
['South', 'East']

# Add append
locations = ["North", "South", "East", "West"]
locations.append("Central")
locations.append("Not Found")
print(locations)
['North', 'South', 'East', 'West', 'Central', 'Not Found']

# Remove pop
locations = ["North", "South", "East", "West", "Central", "Not Found"]
locations.pop(-1)
print(locations)
['North', 'South', 'East', 'West', 'Central']

# For loop
fruits_list = ["Apple", "Orange", "Berries", "Mango", "Melon"]
for selected_fruit in fruits_list:
    print(selected_fruit)
Apple
Orange
Berries
Mango
Melon

# While loop descending
a = 3
while (a > 0):
    a = a-1
    print(a)
2
1
0

# While loop ascending
a = 0
while (a < 3):
    a = a+1
    print(a)
1
2
3

# Dictionary
colours = dict(
    apple='red',
    pear='green',
    mango='yellow',
    berries='purple'
    )
    
colours['apple']
'red'

# Use d[key] to find values in dictionary
d = {"tom":111, "Fio":222, "Gin":333}
for key in d:
    print("key:",key,"values:",d[key])

# Input
name = input("Enter your name: ")
print(name)