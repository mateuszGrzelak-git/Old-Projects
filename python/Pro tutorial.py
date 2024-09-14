squares = [1,2,3,4,5]
print(squares + [6,7,8,9])

print()

a,b = 0,1
while a<1000:
    print(a, end=',') #end dodaje na końcu każdej liczby co chcesz
    a,b = b, a+b
