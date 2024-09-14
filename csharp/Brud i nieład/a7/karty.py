import random

def shuffle(kolekcja):
    kolekcja

def gra(gracz1,gracz2):
    if gracz1==0:
        print("gracz1 wygrywa")
    elif gracz2==0:
        print("gracz2 wygrywa")
    if len(gracz1)>len(gracz2):
        for x in len(gracz2):
            


zmiana = True
gracz1 = []
gracz2=[]
a = [2,2,2,2,3,3,3,3,4,4,4,4,5,5,5,5,6,6,6,6,7,7,7,7,8,8,8,8,9,9,9,9,10,10,10,10,11,11,11,11,12,12,12,12,13,13,13,13,14,14,14,14,15,15]
for x in a:
    losowe = random.randint(0,len(a))
    if random:
        gracz1.append(a[losowe])
        a.remove(losowe)
        zmiana = False
    else:
        gracz2.append(a[losowe])
        a.remove(losowe)
        zmiana=True