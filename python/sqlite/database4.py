import sqlite3

#conn = sqlite3.connect(':memory:')

conn = sqlite3.connect('customer3.db')#pod customr.db

#create a cursor
c = conn.cursor()

c.execute("SELECT * FROM customers")
#c.fetchone()
#c.fetchmany(3)
print(c.fetchall())

print("success")

#Commit our command
conn.commit()

#Close our connection
conn.close()
