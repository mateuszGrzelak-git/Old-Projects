import sqlite3

#conn = sqlite3.connect(':memory:')

conn = sqlite3.connect('customer3.db')#pod customr.db

#create a cursor
c = conn.cursor()

c.execute("SELECT * FROM customers")
print(c.fetchone()[0])
#c.fetchmany(3)
#print(c.fetchall())
print()
items = c.fetchall()

print(items)
print()
for item in items:
    print(item[0] + " " + item[1] + " \t\t " + item[2])

#Commit our command
conn.commit()

#Close our connection
conn.close()
