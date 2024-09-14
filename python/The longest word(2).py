"""
You have to get a new driver's license and you show up at the office at the same time as 4 other people. The office says that they will see everyone in alphabetical order and it takes 20 minutes for them to process each new license. All of the agents are available now, and they can each see one customer at a time. How long will it take for you to walk out of the office with your new license?

Task 
Given everyone's name that showed up at the same time, determine how long it will take to get your new license.

Input Format 
Your input will be a string of your name, then an integer of the number of available agents, and lastly a string of the other four names separated by spaces.

Output Format 
You will output an integer of the number of minutes that it will take to get your license.

Sample Input
'Eric'
2
'Adam Caroline Rebecca Frank'

Sample Output 
40
"""
my_name = "Eric"#input("Wpisz swoje imię: ")
agents = 2#int(input("Wpisz liczbę agentów: "))
others = "Adam Caroline Rebecca Frank"#input("Wpisz imiona pozostałych osób: ")
time = 40
e = 0

others = others + " " + my_name
others = others.split(" ")
for a in others:
    if a[0]<

"""    
for x in others:
    if x==my_name:
        c+=1
        break
    else:
        c+=1
c = (e+1)/agents
d = c*time
print(d)
"""



                    

