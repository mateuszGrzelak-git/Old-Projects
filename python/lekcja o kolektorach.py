from collections import Counter
from collections import namedtuple
from collections import OrderedDict
from collections import defaultdict
from collections import deque
a = "aaaaaaabbbbbbbbbccccc"
my_counter = Counter(a)
print(my_counter)
print(my_counter.values())
print(my_counter.keys())
print(my_counter.items)
print(my_counter.most_common(2))
print(my_counter.most_common(2)[0][0])
print(list(my_counter.elements()))
Point = namedtuple('Point', 'x,y')
pt = Point(1,-4)
print(pt)
print(pt.x,pt.y)
ordered_dict=OrderedDict()#to to samo co {}
ordered_dict['b'] = 2
ordered_dict['c'] = 3
ordered_dict['d'] = 4
ordered_dict['a'] = 1
print(ordered_dict)
d = defaultdict(int)#float, list nie można {}
d['a']=1
d['b']=2
print(d)
print(d['a'])
print(d['b'])
print(d['c'])#default 0
d = deque()
d.append(1)
d.append(2)
d.appendleft(3)
print(d)

d.pop
print(d)
d.popleft()
print(d)
d.clear()
print(d)
print()
d = deque()
d.append(1)
d.append(2)
d.appendleft(3)
d.extendleft([4,5,6])#można samo extend
print(d)
d.rotate(-2)
print(d)





