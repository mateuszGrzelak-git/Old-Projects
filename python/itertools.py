from itertools import product
from itertools import permutations
from itertools import combinations
from itertools import combinations_with_replacement
from itertools import accumulate as acc
from itertools import groupby as gp
from itertools import count, cycle, repeat
import operator
#śmieszna mieszanka
a = [1,2]
b = [3,4]
prod = product(a,b)#można repeat po , robi 2 list w listach
print(list(prod))
print()
a = [1,2,3]
perm = permutations(a)# po przecinku pomijamy dwójkę
print(list(perm))

a = [1,2,3,4]
comb = combinations(a,2)#possible combinations
print(list(comb))
comb_wr = combinations_with_replacement(a,2)
print(list(comb_wr))
a = [1,2,3,4]
ac = acc(a)
print(a)
print(list(ac))
ad = acc(a, func=operator.mul)
print(ad)
a = [1,2,5,3,4]
ad = acc(a, func=max)
print(ad)

def smaller(x):
    return x<3
a = [1,2,3,4]
group=gp(a, key=smaller)#można lambda x: x<3
print(group)
for key, value in group:
    print(key,list(value))
persons=[{'name': 'Tim', 'age': 25}, {'name':'Dan', 'age':25},
         {'name':'Lisa', 'age':27},{'name':'Claire', 'age':28}]
group=gp(persons, key=lambda x:x['age'])
for key,value in group:
    print(key, list(value))

for i in count(10):#nieskończoność od 10
    print(i)
    if i==15:
        break

x = [1,2,3]
d = 0
for i in cycle(x):#nieskończony cykl do 14 znaków
    print(i)
    d+=1
    if d==14:
        break
for i in repeat(1, 4):#po przecinku stop
    print(i)
    

