#using prompt with raw_input
from sys import argv
script,name = argv
prompt = '> ' 
print "hello %s !..\n what do you like to have ..\n1:crapts\n2:scuesh\n3:uslipahh"% name
choice = raw_input(prompt)
print "\nhere is your order:%r"% choice