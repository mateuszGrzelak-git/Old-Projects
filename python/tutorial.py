x = [2,3,4]
y = x[:]#copy
x = [1,2,4]
print(x)
print(y)


for x in range(1,10,3):
    print(x)
print()
for x in range(10,1,-1):#tylko jeśli 3: -1
    print(x)
print()


c=[2,4,3,8,9,1]
for d,element in enumerate(c):
    print(d,element)
print()
print("Hi"*3)
print()



x = [0,1,2,3,4,5,6,7,8]
sliced = x[0:5:2]
print(sliced)
print()
print(x[::-1])
print()

x = set()#empty set do wpisania setu do którego możemy nie wracać
s = {4,32,2,2}#set  trzeba coś wpisać
z = {3,4,22,1}
s.add(5)
s.remove(2)
print(s)
print(4 in s)
print(s.union(z))
print(s.difference(z))
print(s.intersection(z))
print()

x = {'key':"Norbert", 'es':"łatwo"}
x['key2'] = 5
print(x['es'])
print(x['key2'])
print(x.values())#można z list
del x['key']
print(x)
print()

for key,value in x.items():
    print(key,value)#bo 2
print()
for key in x:
    print(key,x[key])#bo 2
print()

x = [x + 5 for x in range(5)]
print(x)

x = [[0 for x in range(100)] for x in range(5)]
print(x)

x = [i for i in range(100) if i%5==0]
print(x)

x = {i for i in range(100) if i%5==0}
print(x)

x = (i for i in range(100) if i%5==0) # można tuple dla zrozumienia
print(x)
