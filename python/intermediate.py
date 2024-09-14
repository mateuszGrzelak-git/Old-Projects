my_tuple= "Juliusz", 28, "Boston"

name,age,city = my_tuple
print(name)
print(age)
print(city)
print()

d=(0, 1, 2, 3, 4)
i1,*i2,i3=d
print(i1)
print(i2)
print(i3)
print()

mydict = {"name": "Max", "age": 28, "city": "New York"}
print(mydict)

value = mydict["name"]
print(value)
mydict["email"] = "ankdflsflkn"
print(mydict)
mydict["email"] = "ala@ala.pl"
print(mydict)


mydict2 = dict(name="Mary", age=27, city="Boston")
print(mydict2)


myDict = {"name":"Max", "age":28, "city":"NewYork"}
print(myDict)

del myDict["name"]
print(myDict)
myDict.pop("age")
print(myDict)
myDict.popitem()#ostatnie
print(myDict)

if "name" in mydict:
    print(mydict["name"])

try:
    print(mydict["lastname"])
except KeyError:
    print("Error")

for key in mydict:
    print(key)
print()
for key in mydict.keys():
    print(key)
for value in mydict.values():
    print(value)
for key, value in mydict.items():
    print(key, value)
print()
mydict_cpy=mydict# zmienia oryginał
my_dict = mydict.copy()
print(my_dict)
print()

my_dict3={"name":"Max", "age":28, "email":"you@ja.com"}
my_dict2 = dict(name="Marry", age=27, city="Boston")
my_dict3.update(my_dict2) #zmienia 3
print(my_dict3)
print()

dictionar={3:9,6:36,9:81}
print(dictionar)

value = dictionar[3]
print(value)

myTuple=(8,7)#nie może być [] czyli list
a = {myTuple:15}
print(a)
print()

myset={1,2,3,1,2}
print(myset)
myset2=set("Hello")
print(myset2)
myset_empty=set()
myset_empty.add(1)
myset_empty.add(2)
myset_empty.add(3)
myset_empty.remove(2)#myset_empty.discard() to to samo ale jak nie wiemy czy jest nic się nie dzieje
print(myset_empty)
freenumbers={1,3,5,6}
addnumbers=[2,6,8]
print(freenumbers.union(addnumbers))
i=freenumbers.intersection(addnumbers)
print(i)
diff=freenumbers.difference(addnumbers)#które są w freenumbers ale nie w addnumbers
#dif=addnumbers.symetric_difference(freenumbers)to co nie jest wspólne
print(diff)
#print(dif)
freenumbers.update(addnumbers)#dodaje
freenumbers.intersection_update(addnumbers)#w każdym
#freenumbers.difference.update(addnumbers) na odwrót ^ z freenumbers
#freenumbers.symetric_difference_update(addnumbers) które nie ma w każdym
print(freenumbers)
print()
setA={1,2,3,4,5,6}
setB={1,2,3}
print(setA.issubset(setB))
print(setB.issubset(setA))
print()
print(setA.issuperset(setB))
print(setB.issuperset(setA))
print()
print(setA.isdisjoint(setB))
setC={7,8}
print(setA.isdisjoint(setC))
print()
setB=set(setA)#robi kopię
setB.add(7)
print(setB)
print(setA)
print()
a = frozenset([1,2,3,4])#nic nie można zrobić dodać może być union, section, difference
print(a)
