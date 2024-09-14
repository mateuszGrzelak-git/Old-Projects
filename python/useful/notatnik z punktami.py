import time
from datetime import date
c = input("Wpisz tytuł: ")
a = int(input("Wpisz liczbę punktów: "))
today = date.today()
file = open(c + " " + str(today) + ".txt", "a")
for x in range(1,a+1):
    file.write(str(x) + ". \n")
file.close()
