#file Read 
from sys import argv
from os.path import exists
script,filename,mode  = argv
if exists(filename) == True:
	print "this is your file %s"%filename
	file = open(filename,mode)
	if mode == 'r':
		print "contents in your file:\n%s"%file.read()
	elif mode == 'w'or mode =='a':
		contents = raw_input("type your contents here:")
		file.write(contents)
else:
	print "your file does not exists"

