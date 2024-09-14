
add10 = lambda x:x+10
print(add10(5))

mult = lambda x,y:x*y
print(mult(2,4))

points2D = [(1,2), (15,1), (5,-1), (10,4)]

points2D_sorted = sorted(points2D, key=lambda z:z[1])
points2D_sorte = sorted(points2D, key=lambda z:z[0] * z[1])

print(points2D)
print(points2D_sorted)
print(points2D_sorte)

a = [1,2,3,4,5]
b = map(lambda x:x*2,a)
print(list(b))
#2 sposób
c = [x*2 for x in a]
print(c)
