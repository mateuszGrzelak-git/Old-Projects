"""from turtle import *
color('red', 'yellow')
begin_fill()
while True:
    forward(1)
    left(1)
    if abs(pos()) < 1:
        break
end_fill()
done()
"""
from turtle import *
color('red', 'yellow')
begin_fill()
while True:
    goto(200,0)
    goto(200,200)
    goto(0,200)
    goto(0,0)
    
    if abs(pos()) < 1:
        break
end_fill()
done()
