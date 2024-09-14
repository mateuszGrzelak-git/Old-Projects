import sqlite3

#conn = sqlite3.connect(':memory:')

conn = sqlite3.connect('customer3.db')#pod customr.db

#create a cursor
c = conn.cursor()

c.execute("SELECT rowid, * FROM customers WHERE last_name LIKE 'Nowa%'")#zamiast LIKE można stosować age > 18, czyli rzeczy z True

print()
items = c.fetchall()

#Commit our command
conn.commit()

for item in items:
    print(item)

#Close our connection
conn.close()
