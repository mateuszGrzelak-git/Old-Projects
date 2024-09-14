import sqlite3

#conn = sqlite3.connect(':memory:')

conn = sqlite3.connect('customer.db')#pod customr.db

#create a cursor
c = conn.cursor()

#create a table
c.execute("""CREATE TABLE customers (
    first_name text,
    last_name text,
    email text
    )""")
#może być DATABASE

#Commit our command
conn.commit()

#Close our connection
conn.close()
