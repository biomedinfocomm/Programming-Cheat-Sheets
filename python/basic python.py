## basic python

# addition
10 + 10
20

# add and print
print(10 +10)
20

a = "North"
print(a)

# printing values stored in variable
total = 10 + 10
(total)
20

# update a variable must already store a value
+=, -=, *=, /=, **=

a = 10
a += 10
a = 10 + 10
print(a)
20

# convert to round down
round(10.2)
10

# convert to round up
round(10.88)
11

# find type of variables
type("colour")
str

# concatenating two or more string
colours = "red" + " " + "green"
print(colours)
red green

# find length of the locations
locations = ["North", "South", "East", "West"]
print (len(locations))
4

# find positive index of the locations
locations = ["North", "South", "East", "West"]
print(locations[2])
East

# find negative index of the locations
locations = ["North", "South", "East", "West"]
print(locations[-1])
West

# list slicing of the locations
locations = ["North", "South", "East", "West"]
print(locations[1:3])
['South', 'East']

# add append
locations = ["North", "South", "East", "West"]
locations.append("Central")
locations.append("Not Found")
print(locations)
['North', 'South', 'East', 'West', 'Central', 'Not Found']

# remove pop
locations = ["North", "South", "East", "West", "Central", "Not Found"]
locations.pop(-1)
print(locations)
['North', 'South', 'East', 'West', 'Central']

# for loop
fruits_list = ["Apple", "Orange", "Berries", "Mango", "Melon"]
for selected_fruit in fruits_list:
    print(selected_fruit)
Apple
Orange
Berries
Mango
Melon

# while loop descending
a = 3
while (a > 0):
    a = a-1
    print(a)
2
1
0

# while loop ascending
a = 0
while (a < 3):
    a = a+1
    print(a)
1
2
3

# dictionary
colours = dict(
    apple='red',
    pear='green',
    mango='yellow',
    berries='purple'
    )
    
colours['apple']
'red'

# use d[key] to find values in dictionary
d = {"tom":111, "Fio":222, "Gin":333}
for key in d:
    print("key:",key,"values:",d[key])